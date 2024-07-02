using Airportmng.Models;
using Airportmng.Models.BAO.Implementations;
using Airportmng.Models.DAO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Airportmng.Controllers
{
    public class PlaneController : ApiController
    {
       ProjectImplementation p1=new ProjectImplementation(); 
        [HttpGet]
        public IHttpActionResult fetch1()
        {



          var g=p1.fetchAllPlanes(); 
           

     
            if (g == null)
            {
                return BadRequest("No data avilable");
            }

            return Ok(g);
        }
        [HttpPost] 
        public IHttpActionResult insert([FromBody]Plane_table p)
        {
            string msg = p1.Addplene(p);
            if(msg == "Plane added success Fully with ID " + p.Plane_Id)
            {
                return Ok(msg);
            }
            return BadRequest(msg); 
        


        }

    }
}
