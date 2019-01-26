using System;

namespace DevOpsDemo1.Repository
{
    /// <summary>
    /// This is our first main repo
    /// </summary>
    public class CustomerRespository
    {
        public CustomerRespository()
        {
            
        }

        public string GetCustomerName()
        {
            string longDateString = DateTime.Now.ToLongDateString();
            string longTimeString = DateTime.Now.ToLongTimeString();


            return "Current time - " + longDateString + "---" +longTimeString;
        }
    }
}
