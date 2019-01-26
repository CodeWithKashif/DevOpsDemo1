using DevOpsDemo1.Repository;
using System;

namespace DevOpsDemo1.Domain
{
    public class CustomerService
    {
        public CustomerService()
        {
            
        }

        public string GetCustomerName()
        {
            return (new CustomerRespository()).GetCustomerName();
        }
    }
}
