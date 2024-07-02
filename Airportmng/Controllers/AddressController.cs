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
    public class AddressController : ApiController
    {
        ProjectImplementation p1 = new ProjectImplementation();
        [HttpGet]
        public IHttpActionResult fetch1()
        {



            var g = p1.fetchAllAddresses();



            if (g == null)
            {
                return BadRequest("No data avilable");
            }

            return Ok(g);
        }
        [HttpPost]
        public IHttpActionResult insert([FromBody] Addresstable p)
        {
            string msg = p1.Addaddresses(p);
            if (msg == "Address added success Fully with ID " + p.AddressId)
            {
                return Ok(msg);
            }
            return BadRequest(msg);



        }

    }
}
