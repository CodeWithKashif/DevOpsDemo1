﻿using System;

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
            return DateTime.Now.ToLongDateString() + "---" +DateTime.Now.ToLongTimeString();
        }
    }
}
