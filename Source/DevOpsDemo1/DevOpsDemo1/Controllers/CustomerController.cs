using DevOpsDemo1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevOpsDemo1.Controllers
{
    public class CustomerController : ApiController
    {
        public CustomerController()
        {

        }

        public string GetCustomerName()
        {
            string name = new CustomerService().GetCustomerName();
            return "Kashif - " + name;
        }
    }

}
