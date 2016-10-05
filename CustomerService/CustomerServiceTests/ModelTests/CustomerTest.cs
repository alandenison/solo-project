using Xunit;
using CustomerService.Models;

namespace CustomerService.Tests
{
    public class CustomerTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var customer = new Customer();
            customer.Name = "Giggy Sanjan";

            //Act
            var result = customer.Name;

            //Assert
            Assert.Equal("Giggy Sanjan", result);
        }
    }
}