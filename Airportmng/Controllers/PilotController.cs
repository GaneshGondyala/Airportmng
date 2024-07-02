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
    public class PilotController : ApiController
    {
        ProjectImplementation pi=new ProjectImplementation();    
        [HttpPost]
        public IHttpActionResult Addthepilot([FromBody]Pilot_table p)
        {
             string msg = pi.AddPilot(p);
            if(msg== "Pilate added success Fully with ID " + p.Pilot_Id)
                return Ok(msg);
            else
                return BadRequest(msg); 
            
           


        }
        [HttpGet]
        public IHttpActionResult fetchtheallpilots()
        {
            try
            {
                object data = pi.fetchAllpilots();
                return Ok(data);
            }
            catch (Exception )
            {
                return BadRequest("unable to fetch");
            }


        }
    }
}
