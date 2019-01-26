using System;
using DevOpsDemo1.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsDemo1.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly CustomerService _customerService;

        public UnitTest1()
        {
            _customerService = new CustomerService();
        }

        [TestMethod]
        public void should_return_result()
        {
            var result = _customerService.GetCustomerName();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void should_return_result1()
        {
            //This is test comment
            var result = _customerService.GetCustomerName();
            Assert.IsTrue(result.Length > 0);
        }

    }
}
