using System;

namespace DevOpsDemo1.Repository
{
    /// <summary>
    /// This is our first main repo push from console
    /// </summary>
    public class CustomerRespository
    {
        public CustomerRespository()
        {
            
        }

        public string GetCustomerName()
        {
            return DateTime.Now.ToLongDateString() + "---" +DateTime.Now.ToLongTimeString();
        }
    }
}
