using Airportmng.Models;
using Airportmng.Models.BAO.Implementations;
using Airportmng.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Airportmng.Controllers
{
    public class managerrController : ApiController
    {
        ProjectImplementation p=new ProjectImplementation();
        [HttpGet]
        public IHttpActionResult gettallmng()
        {
            var d= p.fetchAllManagers();
            return Ok(d);

        }
        [HttpPost]
        public IHttpActionResult addmng([FromBody]ManagerTable m)
        {

           string w= p.Addmanagers(m);
            if(w== "Manager  added success Fully with ID " + m.ManagerId)
            {
                return Ok(w);
            }
            return BadRequest(w);
        }
    }
}
