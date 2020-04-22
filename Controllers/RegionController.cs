using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDropDown.Shared.DataAccess;
using EFDropDown.Shared.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFDropDown.Controllers
{
    
    [Route("api/Region")]
    public class RegionController : Controller
    {
        DataAccessLayer db = new DataAccessLayer();

        [HttpGet]
        [Route("GetRegion")]
        public IEnumerable<Region> GetRegion()
        {
            return db.GetAllRegion().AsQueryable();
        }

        [HttpGet]
        [Route("GetTerritories")]
        public IEnumerable<Territories> GetTerritories()
        {
            return db.GetAllTerritoriesData().AsQueryable();
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Region> Get()
        {
            return db.GetAllRegion().AsQueryable();
        }

        //// GET api/<controller>/5
        [HttpGet("{id}")]
        public IEnumerable<Territories> Get(int id)
        {
            return db.GetTerritoriesData(id).AsQueryable();
        }
        // GET api/<controller>/5

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
