using Airportmng.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Airportmng.Controllers
{
    public class AdminController : ApiController
    {
        AirPortDatabaseEntities8 d=new AirPortDatabaseEntities8();
        [HttpGet]
        public IHttpActionResult fetchAdmin()
        {

            List<Admintable> ad=(from s in d.Admintables
                                 select s).ToList();
            if(ad.Count==0)
            {
                return BadRequest("No data found");
            }
            return Ok(ad);

        }
    }
}
