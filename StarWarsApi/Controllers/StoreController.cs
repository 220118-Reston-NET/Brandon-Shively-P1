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
            Log.Information("User is attempting to view all stores.");
            try
            {
                Log.Information("User successfully viewed all stores.");
                return Ok(_starWarsBL.GetAllStores());
            }
            catch (SqlException)
            {
                Log.Information("User failed to view all stores.");
                return NotFound();
            }
        }

        // GET: api/Store/5
        [HttpGet("GetStoreByName/{storeName}")]
        public IActionResult Get(string storeName)
        {
            Log.Information("User is attempting to view the store: "+storeName);
            try
            {
                Log.Information("User was successful at viewing the store.");
                return Ok(_starWarsBL.SearchStoreFront(storeName));
            }
            catch (SqlException)
            {
                Log.Information("User failed too view the store.");
                return NotFound();
            }
        }

        // POST: api/Store
        [HttpPost("AddStore")]
        public IActionResult Post([FromBody] Storefront n_storeFront)
        {
            Log.Information("User is attempting to add a store.");
            try
            {
                Log.Information("User succeeded at addaing a store.");
                return Ok(_starWarsBL.AddStoreFront(n_storeFront));
            }
            catch (SqlException)
            {
                Log.Information("User failed to add a store.");
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
