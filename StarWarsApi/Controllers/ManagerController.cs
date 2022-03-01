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
            try
            {
                _authorization = true;
                return Ok(_starWarsBL.ManagerLogin(_userName, _password));
            }
            catch (SqlException)
            {
                return NotFound();
            }
        }

        // GET: api/Manager/5
        [HttpGet("StoreOrderHistory/")]
        public IActionResult Get(int _storeID, string _orderMethod)
        {
            try
            {
                return Ok(_starWarsBL.StoreOrder(_storeID, _orderMethod));
            }
            catch (SqlException)
            {
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
            try{
                if(_authorization){
                    return Ok(_starWarsBL.ReplenishInventory(_storeID, _addedQuantity, _lineItemID));
                }
                else{
                    return Unauthorized();
                }
            }
            catch(SqlException){
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
