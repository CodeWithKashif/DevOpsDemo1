using DevOpsDotNetCore.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsDotNetCore.UnitTests
{
    [TestClass]
    public class CustomerServiceTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(new CustomerService().GetCustomerName());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(new CustomerService().GetCustomerName().Length > 0);
        }
    }
}
