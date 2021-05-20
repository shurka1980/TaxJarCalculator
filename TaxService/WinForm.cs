using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using TaxCalculator.RequestModels;
using TaxCalculator.Service;
using TaxCalculator.Service.Interfaces;
using LineItem = TaxCalculator.RequestModels.LineItem;


namespace WinFormUI
{
    public partial class TaxForm : Form
    {
        private readonly ITaxCalculatorClient _taxCalculator;
        
        public TaxForm(ITaxCalculatorClient taxCalculator)
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            _taxCalculator = taxCalculator;
        }

        #region GetTaxRatesForLocationRegion
        
        private async void GetTaxRatesForLocation_Click(object sender, EventArgs e)
        {
            try
            {
                var country = txtCountry.Text;
                var zip = txtZip.Text;
                var state = txtState.Text;
                var city = txtCity.Text;
                var street = txtStreet.Text;


                var result = await _taxCalculator.GetTheTaxRatesForALocation(zip, country, state, city, street);
                var stringBuilder = new StringBuilder();
                stringBuilder.Append($"============================== {Environment.NewLine}");
                stringBuilder.Append($"Combined Rate is: {result.Rate.CombinedRate}{Environment.NewLine}");
                stringBuilder.Append($"============================== {Environment.NewLine}");
                stringBuilder.Append($"Tax rates for location are : {Environment.NewLine}");
                stringBuilder.Append($"City is: {result.Rate.City}{Environment.NewLine}");
                stringBuilder.Append($"City Rate is: {result.Rate.CityRate}{Environment.NewLine}");
                stringBuilder.Append(
                    $"Combined District Rate is: {result.Rate.CombinedDistrictRate}{Environment.NewLine}");
                
                stringBuilder.Append($"Country is: {result.Rate.Country}{Environment.NewLine}");
                stringBuilder.Append($"Country rate is: {result.Rate.CountryRate}{Environment.NewLine}");
                stringBuilder.Append($"County is: {result.Rate.County}{Environment.NewLine}");
                stringBuilder.Append($"County rate is: {result.Rate.CountyRate}{Environment.NewLine}");
                stringBuilder.Append($"Freight taxable is: {result.Rate.FreightTaxable}{Environment.NewLine}");
                stringBuilder.Append($"State is: {result.Rate.State}{Environment.NewLine}");
                stringBuilder.Append($"State rate is: {result.Rate.StateRate}{Environment.NewLine}");
                stringBuilder.Append($"zip is: {result.Rate.Zip}{Environment.NewLine}");
                txtTaxRates.Text = stringBuilder.ToString();
            }
            catch (Exception ex)
            {
                // this is not user-friendly, but will leave it for debugging purposes
                txtTaxRates.Text = ex.Message; 
                //TODO: Implement logging mechanism to write any logs to the file
            }
        }

        // in the assignemnet it needs to return just the total tax collected
        // which would be result.Rate.CombinedRate, but for the demo we will return everything
        // to return just the total tax collected our method signature will be
        // private async Task<double> GetTheTaxRatesForALocation(string zip, string country, string state,
        //                                                                  string city, string street)

        #endregion

        #region CalculateTaxesForAnOrderRegion

        private async void CalculateTaxesForAnOrder_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtAmount.Text, out var amount))
            {
                amount = 0.0f;
            }

            if (!float.TryParse(txtShipping.Text, out var shipping))
            {
                shipping = 0.0f;
            }

            if (!int.TryParse(txtQuantity.Text, out var quantity))
            {
                quantity = 0;
            }

            if (!double.TryParse(txtUnitPrice.Text, out var unitPrice))
            {
                unitPrice = 0.0d;
            }

            var order = new Order
            {
                FromCountry = txtFromCountry.Text,
                FromZip = txtFromZip.Text,
                FromState = txtFromState.Text,
                ToCountry = txtToCountry.Text,
                ToZip = txtToZip.Text,
                ToState = txtToState.Text,
                Amount = amount,
                Shipping = shipping,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        Quantity = quantity,
                        UnitPrice = unitPrice,
                        ProductTaxCode = txtProductTaxCode.Text
                    }
                }
            };

            var result = await _taxCalculator.CalculateTheTaxesForAnOrder(order);
            
            txtTotalTaxToCollect.Text =
                    @$"Total amount to collect: {result.Tax.AmountToCollect.ToString(CultureInfo.InvariantCulture)}";
        }

        #endregion
    }
}
