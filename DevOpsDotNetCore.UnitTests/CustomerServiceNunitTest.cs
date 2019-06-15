using DevOpsDotNetCore.Domain;
using NUnit.Framework;

namespace DevOpsDotNetCore.UnitTests
{
    [TestFixture]
    public class CustomerServiceNunitTest
    {

        [Test]
        public void TestMethod1()
        {
            Assert.IsNotNull(new CustomerService().GetCustomerName());
        }

        [Test]
        public void TestMethod2()
        {
            Assert.IsTrue(new CustomerService().GetCustomerName().Length > 0);
        }
    }
}
