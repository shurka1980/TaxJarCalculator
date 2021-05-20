using Xunit;
using TaxCalculator.RequestModels;
using TaxCalculator.Service;

namespace TaxCalculator.Tests
{
    public class TaxJarCalculatorTests
    {

        #region GetTheTaxRatesForALocationTests

        
        [Fact(DisplayName = "TaxJarCalculator ~ GetTheTaxRatesForALocation_Should_ThrowException_WhenZipCodeIsNull => Sad path")]
        public void GetTheTaxRatesForALocation_Should_ThrowException_WhenZipCodeIsNull()
        {
            //Arrange
            string zipCode = "";
            var taxCalculator = new TaxJarCalculator();

            //Act
            var result = taxCalculator.GetTheTaxRatesForALocation(zipCode, null, null, null, null);

            //Assert
            Assert.Equal("Zip code is required. (Parameter 'zip')", result.Exception?.InnerException?.Message);
        }

        
        [Fact(DisplayName = "TaxJarCalculator ~ GetTheTaxRatesForALocation_Should_ThrowException_WhenZipCodeIsInAWrongFormatForUS => Sad path")]
        public void GetTheTaxRatesForALocation_Should_ThrowException_WhenZipCodeIsInAWrongFormatForUS()
        {
            //Arrange
            string zipCode = "11234-12520";
            string country = "US";
            var taxCalculator = new TaxJarCalculator();

            //Act
            var result = taxCalculator.GetTheTaxRatesForALocation(zipCode, country, null, null, null);
            
            //Assert
            Assert.Equal("Zip code format for US is not correct. (Parameter 'validZipCode')", result.Exception?.InnerException?.Message);
        }

        [Fact(DisplayName = "TaxJarCalculator ~ GetTheTaxRatesForALocation_Should_ThrowException_WhenZipCodeIsInAWrongFormatForCA => Sad path")]
        public void GetTheTaxRatesForALocation_Should_ThrowException_WhenZipCodeIsInAWrongFormatForCA()
        {
            //Arrange
            string zipCode = "V5K0AX1";
            string country = "CA";
            var taxCalculator = new TaxJarCalculator();

            //Act
            var result = taxCalculator.GetTheTaxRatesForALocation(zipCode, country, null, null, null);

            //Assert
            Assert.Equal("Zip code format for CA is not correct. (Parameter 'validZipCode')", result.Exception?.InnerException?.Message);
        }

        [Fact(DisplayName = "TaxJarCalculator ~ GetTheTaxRatesForALocation_Should_ThrowException_WhenCountryCodeIsNotEqual2Characters => Sad path")]
        public void GetTheTaxRatesForALocation_Should_ThrowException_WhenCountryCodeIsNotEqual2Characters()
        {
            //Arrange
            string zipCode = "99010";
            string country = "USA";
            var taxCalculator = new TaxJarCalculator();

            //Act
            var result = taxCalculator.GetTheTaxRatesForALocation(zipCode, country, null, null, null);

            //Assert
            Assert.Equal("Country code should be 2 characters. (Parameter 'country')", result.Exception?.InnerException?.Message);
        }

        [Fact(DisplayName = "TaxJarCalculator ~ GetTheTaxRatesForALocation_Should_ThrowException_WhenStateIsNotEqual2Characters => Sad path")]
        public void GetTheTaxRatesForALocation_Should_ThrowException_WhenStateIsNotEqual2Characters()
        {
            //Arrange
            string zipCode = "99010";
            string country = "US";
            string state = "CAL";
            var taxCalculator = new TaxJarCalculator();

            //Act
            var result = taxCalculator.GetTheTaxRatesForALocation(zipCode, country, state, null, null);

            //Assert
            Assert.Equal("State code should be 2 characters. (Parameter 'state')", result.Exception?.InnerException?.Message);
        }

        #endregion

        #region CalculateTaxesForAnOrderTests

        [Fact(DisplayName = "TaxJarCalculator ~ CalculateTaxesForAnOrder_ThrowException_WhenOrderIsNull => Sad path")]
        public void CalculateTaxesForAnOrder_ThrowException_WhenOrderIsNull()
        {
            //Arrange
            var taxCalculator = new TaxJarCalculator();

            //Act
            var result = taxCalculator.CalculateTheTaxesForAnOrder(null);
            
            //Assert
            Assert.Equal("Order is invalid. (Parameter 'order')", result.Exception?.InnerException?.Message);
        }

        [Fact(DisplayName = "TaxJarCalculator ~ CalculateTaxesForAnOrder_ThrowException_WhenToCountryIsNull => Sad path")]
        public void CalculateTaxesForAnOrder_ThrowException_WhenToCountryIsNull()
        {
            //Arrange
            var taxCalculator = new TaxJarCalculator();
            var order = new Order {ToCountry = null};

            //Act
            var result = taxCalculator.CalculateTheTaxesForAnOrder(order);

            //Assert
            Assert.Equal("to_country is a required parameter. (Parameter 'ToCountry')", result.Exception?.InnerException?.Message);
        }

        [Fact(DisplayName = "TaxJarCalculator ~ CalculateTaxesForAnOrder_ThrowException_WhenCountryIsUSorCAToStateIsNull => Sad path")]
        public void CalculateTaxesForAnOrder_ThrowException_WhenCountryIsUSorCAToStateIsNull()
        {
            //Arrange
            var taxCalculator = new TaxJarCalculator();
            var order = new Order
            {
                ToCountry = "US",
                Shipping = 1.5f
            };

            //Act
            var result = taxCalculator.CalculateTheTaxesForAnOrder(order);

            //Assert
            Assert.Equal("to_state is a required parameter when country is US or CA. (Parameter 'ToState')", result.Exception?.InnerException?.Message);
        }


        #endregion

    }
}
