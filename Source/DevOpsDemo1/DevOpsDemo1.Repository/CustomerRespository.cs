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
            string longDateString = DateTime.Now.ToLongDateString();
            return longDateString + "---" +DateTime.Now.ToLongTimeString();
        }
    }
}
