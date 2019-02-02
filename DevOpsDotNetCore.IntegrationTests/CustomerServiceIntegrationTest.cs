using DevOpsDotNetCore.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsDotNetCore.IntegrationTests
{
    [TestClass]
    public class CustomerServiceIntegrationTest
    {

        [TestMethod]
        public void IntegrationTest_Method1()
        {
            Assert.IsNotNull(new CustomerService().GetCustomerName());
        }

        [TestMethod]
        public void IntegrationTest_Method2()
        {
            Assert.IsTrue(new CustomerService().GetCustomerName().Length > 0);
        }

        [TestMethod]
        public void IntegrationTest_Method3()
        {
            Assert.IsTrue(new CustomerService().GetCustomerName().Length < 100000);
        }

    }
}
