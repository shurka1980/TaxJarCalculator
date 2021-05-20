using System.Threading.Tasks;

using TaxCalculator.RequestModels;
using TaxCalculator.ResponseModels;
using TaxCalculator.Service.Interfaces;

namespace TaxCalculator.Service
{
    public class TaxService 
    {
        private readonly ITaxCalculatorClient _taxCalculatorClient;

        public TaxService(ITaxCalculatorClient taxCalculatorClient)
        {
            _taxCalculatorClient = taxCalculatorClient;
        }

        public async Task<TaxRateForLocation> GetTheTaxRatesForALocation(string zip, string country,
            string state, string city, string street)
        {
            // implement validation
            return await _taxCalculatorClient.GetTheTaxRatesForALocation(zip, country, state, city, street);
        }

        public async Task<TaxForOrders> CalculateTheTaxesForAnOrder(Order order)
        {
            //implement validation
            return await _taxCalculatorClient.CalculateTheTaxesForAnOrder(order);
        }
    }
}