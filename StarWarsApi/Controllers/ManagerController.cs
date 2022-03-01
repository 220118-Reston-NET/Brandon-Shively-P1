using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWarsBL;
using StarWarsDL;
using StarWarsModel;

namespace StarWarsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private bool _authorization = false;
        private IStarWarsStoreBL _starWarsBL;
        public ManagerController(IStarWarsStoreBL p_starwarsBL){
            _starWarsBL = p_starwarsBL;
        }
        // GET: api/Manager
        [HttpGet]
        public IActionResult Get(string _userName, string _password)
        {
            Log.Information("User is attempting to login as a manager using the creditials: Username: "+_userName+ " Password: "+ _password);
            try
            {
                Log.Information("User was successful at logging in as a manager.");
                return Ok(_starWarsBL.ManagerLogin(_userName, _password));
            }
            catch (SqlException)
            {
                Log.Information("User failed to login as a manager.");
                return NotFound();
            }
        }

        // GET: api/Manager/5
        [HttpGet("StoreOrderHistory/")]
        public IActionResult Get(int _storeID, string _orderMethod)
        {
            Log.Information("User is attempting to view store order history.");
            try
            {
                Log.Information("User was successful at viewing store order history.");
                return Ok(_starWarsBL.StoreOrder(_storeID, _orderMethod));
            }
            catch (SqlException)
            {
                Log.Information("User failed to view store order history.");
                return NotFound();
            }
        }

        // POST: api/Manager
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Manager/5
        [HttpPut("ReplenishStoreInventory")]
        public IActionResult Put(int _storeID, int _addedQuantity, int _lineItemID)
        {
            Log.Information("Manager is attempting to replenish store inventory.");
            try{
                Log.Information("Manager was successful at replenishing store inventory.");
                return Ok(_starWarsBL.ReplenishInventory(_storeID, _addedQuantity, _lineItemID));
            }
            catch(SqlException){
                Log.Information("User failed to replenish store inventory.");
                return NotFound();
            }
        }

        // DELETE: api/Manager/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
