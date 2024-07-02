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
    public class PlanehangerController : ApiController
    {
        ProjectImplementation p=new ProjectImplementation();
        [HttpGet]
        public IHttpActionResult gethngplan()
        {
            var q=p.fetchAllPlane_hanger();
            return Ok(q);   

        }
        public IHttpActionResult addplanehanger([FromBody]Plane_hanger h)
        {
           string s= p.AddPlane_hanger(h);  
            return Ok(s);    

        }
    }
}
