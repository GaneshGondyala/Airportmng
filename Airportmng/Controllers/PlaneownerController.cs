using Airportmng.Models.BAO.Implementations;
using Airportmng.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Airportmng.Models.DAO;

namespace Airportmng.Controllers
{
    public class PlaneownerController : ApiController
    {
        ProjectImplementation p1 = new ProjectImplementation();
        SortedDictionary<string, object> map = new SortedDictionary<string, object>();
        [HttpGet]
  
        public IHttpActionResult fetch1()
        {



            var g = p1.fetchAllPlaneowners();



            if (g == null)
            {
             
                return BadRequest("No data avilable");
            }

            return Ok(g);
        }
        [HttpGet]
        public IHttpActionResult fetch3(string email)
        {



            var g = p1.fetchPlaneownerByID(email);  



            if (g == null)
            {
                return BadRequest("No data avilable");
            }

            return Ok(g);
        }
        [HttpPost]
        public IHttpActionResult insert([FromBody] Planeowner_table p)
        {
            string msg = p1.AddPlaneowner(p);
            if (msg == "Plane owner added success Fully with email " + p.Email)
            {
                return Ok(msg);
            }
            return BadRequest(msg);



        }
    }
}
