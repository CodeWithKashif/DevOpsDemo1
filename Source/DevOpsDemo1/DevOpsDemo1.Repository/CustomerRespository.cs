using System;

namespace DevOpsDemo1.Repository
{
    public class CustomerRespository
    {
        public CustomerRespository()
        {
            
        }

        public string GetCustomerName()
        {
            return DateTime.Now.ToLongDateString();
        }
    }
}
