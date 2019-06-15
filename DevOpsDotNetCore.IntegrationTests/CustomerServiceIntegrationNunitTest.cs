using DevOpsDotNetCore.Domain;
using NUnit.Framework;


namespace DevOpsDotNetCore.IntegrationTests
{
    [TestFixture]
    public class CustomerServiceIntegrationNunitTest
    {

        [Test]
        public void IntegrationTest_Method1()
        {
            Assert.IsNotNull(new CustomerService().GetCustomerName());
        }

        [Test]
        public void IntegrationTest_Method2()
        {
            Assert.IsTrue(new CustomerService().GetCustomerName().Length > 0);
        }

        [Test]
        public void IntegrationTest_Method3()
        {
            Assert.IsTrue(new CustomerService().GetCustomerName().Length < 100000);
        }

    }
}
