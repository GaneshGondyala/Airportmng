using Airportmng.Models.BAO.Implementations;
using Airportmng.Models.DAO;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;

namespace Airportmng.Controllers
{
    public class LoginController : ApiController
    {
        ProjectImplementation p1 = new ProjectImplementation();
        [HttpGet]
       [Route("api/Login/ValidateAdmin/{UsernameAdmin}/{PasswordAdmin}")]
        public IHttpActionResult ValidateAdmin(string UsernameAdmin,string PasswordAdmin)
        { 
            bool b=p1.ValidateAdmin(UsernameAdmin,PasswordAdmin); 

            return Ok(b);
        
        }
        [HttpGet]
        [Route("api/Login/ValidateManager/{Usernamemgr}/{Passwordmgr}")]
        public IHttpActionResult ValidateManager(string Usernamemgr, string Passwordmgr)
        {
         
            bool b = p1.ValidateManager(Usernamemgr,Passwordmgr);
            return Ok(b);

        }

    }
}
