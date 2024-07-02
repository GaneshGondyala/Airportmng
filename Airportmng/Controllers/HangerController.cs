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
    public class HangerController : ApiController
    {
        ProjectImplementation p = new ProjectImplementation();
        [HttpGet]
       
        public IHttpActionResult gettallhangers()
        {
           var que= p.fetchAllHangers();
            return Ok(que); 
           
        }
        public IHttpActionResult addhngr(Hanger_table h)
        {
            var que=p.AddHanger(h); 
            if (que == "Hanger added successfully generated ID " + h.HangerId)
            {
                return Ok(que);

            }
            else
            {
                return BadRequest(que);
            }
        }
    }
}
