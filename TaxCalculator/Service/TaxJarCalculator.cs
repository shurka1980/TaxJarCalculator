using System;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TaxCalculator.Service.Interfaces;
using TaxCalculator.RequestModels;
using TaxCalculator.ResponseModels;


namespace TaxCalculator.Service
{    
    public class TaxJarCalculator : ITaxCalculatorClient
    {
        #region GetTheTaxRatesForALocation

        public async Task<TaxRateForLocation> GetTheTaxRatesForALocation(string zip, string country, 
                                                    string state, string city, string street)
            {
                ValidateInputParameters(zip, country, state, city, street);

                var url = BuildUrl(zip, country, state, city, street);
                
                //TODO: this needs to be pulled from appsettings.json file...
                const string baseAddress = "https://api.taxjar.com/v2/";

                url = baseAddress  + url;

            using (var response = await ApiHelper.ApiClient.GetAsync(url))
            {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsAsync<TaxRateForLocation>();
                        
                        return result; 
                    }

                    throw new Exception(response.ReasonPhrase);
                }
            }

        #endregion

        #region CalculateTaxesForAnOrder    

        public async Task<TaxForOrders> CalculateTheTaxesForAnOrder(Order order)
        {
            // TODO: need to get url from appsettings.json config file
            const string url = "https://api.taxjar.com/v2/taxes/";

            ValidateOrderInputParameters(order);

            var jsonOrder = JsonConvert.SerializeObject(order);

            var data = new StringContent(jsonOrder, Encoding.UTF8, "application/json");

            using (var response = await ApiHelper.ApiClient.PostAsync(url, data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<TaxForOrders>();
                    return result;
                }

                throw new Exception(response.ReasonPhrase);
            }
        }


        private void ValidateOrderInputParameters(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "Order is invalid.");
            }
            
            if (string.IsNullOrEmpty(order.ToCountry))
            {
                throw new ArgumentNullException(nameof(order.ToCountry), "to_country is a required parameter.");
            }

            if ((order.ToCountry == "US" || order.ToCountry == "CA") && string.IsNullOrEmpty(order.ToState))
            {
                throw new ArgumentNullException(nameof(order.ToState), "to_state is a required parameter when country is US or CA.");
            }
        }

        #endregion  

        private void ValidateInputParameters(string zip, string country, string state, string city, string street)
        {
            // per API specs zip code is required parameter - remaining parameters are optional, but
            // it is still good to perform some basic validation.

            if (string.IsNullOrEmpty(zip))
            {   
                throw new ArgumentNullException(nameof(zip),"Zip code is required.");
            }

            if (country == "US")
            {
                var usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";

                bool validZipCode = Regex.Match(zip, usZipRegEx).Success;

                if (!validZipCode)
                {
                    throw new ArgumentNullException(nameof(validZipCode),"Zip code format for US is not correct.");
                }
            }

            if (country == "CA")
            {
                var caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
                
                bool validZipCode = Regex.Match(zip, caZipRegEx).Success;

                if (!validZipCode)
                {
                    throw new ArgumentNullException(nameof(validZipCode),"Zip code format for CA is not correct.");
                }
            }

            // TODO: possibly add regex for zip code for other countries.

            // Spain (ES), Portugal (PT) - each country has a 2 character code
            if (country?.Length !=2 && !string.IsNullOrEmpty(country))
            {
                throw new ArgumentNullException(nameof(country),"Country code should be 2 characters."); 
            }

            if (state?.Length != 2 && !string.IsNullOrEmpty(state))
            {
                // TODO: can make it using a list of states, since they are all known...
                // but for now perform simple validation.
                throw new ArgumentNullException(nameof(state),"State code should be 2 characters.");
            }
        }

        private string BuildUrl(string zip, string country, string state, string city, string street)
        {
            var urlBuilder = new StringBuilder();

            urlBuilder.Append($"rates/{zip}?");

            if (!string.IsNullOrEmpty(country))
            {
                urlBuilder.Append($"country={country}");
            }

            if (!string.IsNullOrEmpty(state))
            {
                urlBuilder.Append($"&state={state}");
            }

            if (!string.IsNullOrEmpty(city))
            {
                urlBuilder.Append($"&city={city}");
            }

            if (!string.IsNullOrEmpty(street))
            {
                urlBuilder.Append($"&street={street}");
            }
             
            return urlBuilder.ToString();
        }
    }
}