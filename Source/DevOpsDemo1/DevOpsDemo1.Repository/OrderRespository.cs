using System;

namespace DevOpsDemo1.Repository
{
    public class OrderRespository
    {
        public OrderRespository()
        {
            
        }

        public string GetOrderName()
        {
            return DateTime.Now.ToLongDateString() + "---" +DateTime.Now.ToLongTimeString();
        }
    }
}
