using Airportmng.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Airportmng.Controllers
{
    public class plane_pilotController : ApiController
    {
    AirPortDatabaseEntities8 d=new AirPortDatabaseEntities8();  
        [HttpPost]

        public IHttpActionResult insert([FromBody] Plane_pilot p)
        {
            try
            {
                d.Plane_pilot.Add(p);
                d.SaveChanges();
                return Ok("Pilot ID: " + p.Plane_id + "assigned to plane ID: " + p.Plane_id);

            }
            catch
            {
                return BadRequest("Error while adding");
            }
        }
        [HttpGet]
        public IHttpActionResult fetchpilate_plane()
        {
            var a = (from n in d.Plane_pilot
                     select new { n.ID, n.Pilot_id, n.Plane_id }).ToList();
           
                return Ok(a);
            
               
            
        }


    }

}
