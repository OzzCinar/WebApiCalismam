using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiFirstWork.Controllers
{
    
    public class FirsController : ApiController
    {
        [HttpGet]
        public string[] Sehirler ()
        {
            return new string[] {"Ankara", "Samsun" ,  "Ordu"};  
        }


    }
}
