using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarWarsBL;
using StarWarsDL;
using StarWarsModel;

namespace StarWarsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private IStarWarsStoreBL _starWarsBL;
        public StoreController(IStarWarsStoreBL p_starWarsBL){
            _starWarsBL = p_starWarsBL;
        }
        // GET: api/Store
        [HttpGet]
        public IActionResult GetAllStores()
        {
            try
            {
                return Ok(_starWarsBL.GetAllStores());
            }
            catch (SqlException)
            {
                return NotFound();
            }
        }

        // GET: api/Store/5
        [HttpGet("GetStoreByName/{storeName}")]
        public IActionResult Get(string storeName)
        {
            try
            {
                return Ok(_starWarsBL.SearchStoreFront(storeName));
            }
            catch (SqlException)
            {
                return NotFound();
            }
        }

        // POST: api/Store
        [HttpPost("AddStore")]
        public IActionResult Post([FromBody] Storefront n_storeFront)
        {
            try
            {
                return Ok(_starWarsBL.AddStoreFront(n_storeFront));
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }

        // PUT: api/Store/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Store/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
