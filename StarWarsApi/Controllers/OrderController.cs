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
    public class OrderController : ControllerBase
    {
        private IStarWarsStoreBL _starWarsBL;
        public OrderController(IStarWarsStoreBL p_starwarsBL){
            _starWarsBL = p_starwarsBL;
        }
        // GET: api/Order
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Order/5
        [HttpGet("CustomerOrderHistory")]
        public IActionResult Get(int _customerID, string _orderMethod)
        {
            Log.Information("Customer is attempting to view customer order history for Customer ID: "+_customerID);
            try
            {
                Log.Information("Customer was succesful at viewing customer order history.");
                return Ok(_starWarsBL.CustomerOrder(_customerID, _orderMethod));
            }
            catch (SqlException)
            {
                Log.Information("Customer failed to view customer order history.");
                return NotFound();
            }
        }

        // POST: api/Order
        [HttpPost ("PlaceOrder")]
        public IActionResult Post([FromBody] Order p_order)
        {
            Log.Information("Customer is attempting to place an order.");
            try{
                Log.Information("Customer was successful at placing an order.");
                return Ok(_starWarsBL.PlaceOrder(p_order._lineItemID, p_order._totalPrice, p_order._quantity, p_order._storeID, p_order._customerID));
            }
            catch(SqlException){
                Log.Information("Customer failded at placing an order.");
                return Conflict();
            }        
        }

        // PUT: api/Order/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Order/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
