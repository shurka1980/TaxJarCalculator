using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using TaxCalculator.RequestModels;
using TaxCalculator.ResponseModels;
using TaxCalculator.Service;
using TaxCalculator.Service.Interfaces;
using Xunit;
using LineItem = TaxCalculator.RequestModels.LineItem;

namespace TaxCalculator.Tests
{
    public class TaxServiceTests
    {
        private readonly Mock<ITaxCalculatorClient> _mockTaxCalculatorClient;
        private readonly TaxService _taxService;
        
        public TaxServiceTests()
        {
            _mockTaxCalculatorClient = new Mock<ITaxCalculatorClient>();
            _taxService = new TaxService(_mockTaxCalculatorClient.Object);
        }

        [Fact(DisplayName = "TaxService ~ GetTheTaxRatesForALocation => Happy Path")]
        public async Task GetTheTaxRatesForALocation_HappyPath()
        {
            //Arrange
            _mockTaxCalculatorClient.Setup(client =>
                    client.GetTheTaxRatesForALocation(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns(Task.FromResult(new TaxRateForLocation()));

            //Act
            var result = await _taxService.GetTheTaxRatesForALocation("99700", "US", "CA", "", "");

            //Assert
            _mockTaxCalculatorClient.VerifyAll();
            Assert.NotNull(result);
        }

        [Fact(DisplayName = "TaxService ~ CalculateTaxesForAnOrder => Happy Path")]
        public async Task CalculateTheTaxesForAnOrder_HappyPath()
        {
            //Arrange

            var order = new Order
            {
                ToZip = "V5K0AX1",
                ToCountry = "CA",
                Shipping = 1.4f,
                Amount = 1.0f,
                FromCountry = "US",
                FromState = "FL",
                ToState = "",
                FromZip = "33150",
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        ProductTaxCode = "31000",
                        Quantity = 1,
                        UnitPrice = 2.0
                    }
                }
            };

            _mockTaxCalculatorClient.Setup(client => client.CalculateTheTaxesForAnOrder(order)).Returns(
                Task.FromResult(new TaxForOrders()));

            //Act
            var result = await _taxService.CalculateTheTaxesForAnOrder(order);

            //Assert
            _mockTaxCalculatorClient.VerifyAll();
            Assert.NotNull(result);
        }
    }
}
