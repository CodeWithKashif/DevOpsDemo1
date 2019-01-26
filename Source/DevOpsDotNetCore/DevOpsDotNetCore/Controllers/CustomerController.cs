using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsDotNetCore.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsDotNetCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        public CustomerController()
        {
            
        }

        [Route("GetCustomerName")]
        public string GetCustomerName()
        {
            return new CustomerService().GetCustomerName();
        }
    }
}