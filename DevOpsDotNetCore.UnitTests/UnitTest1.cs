using DevOpsDotNetCore.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsDotNetCore.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(new CustomerService().GetCustomerName());
        }
    }
}
