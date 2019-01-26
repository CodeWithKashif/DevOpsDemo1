using System;

namespace DevOpsDotNetCore.Domain
{
    public class CustomerService
    {
        public CustomerService()
        {

        }

        public string GetCustomerName()
        {
            return DateTime.Now.ToLongDateString() + " -- " + DateTime.Now.ToLongTimeString();
        }
    }
}
