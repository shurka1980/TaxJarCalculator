using System.Threading.Tasks;
using TaxCalculator.RequestModels;
using TaxCalculator.ResponseModels;

namespace TaxCalculator.Service.Interfaces
{
    public interface ITaxCalculatorClient
    {
        Task<TaxRateForLocation> GetTheTaxRatesForALocation(string zip, string country, string state, string city, string street);
        Task<TaxForOrders> CalculateTheTaxesForAnOrder(Order order);
    }
}