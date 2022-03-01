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
    public class CustomerController : ControllerBase
    {
        private IStarWarsStoreBL _starWarsBL;
        public CustomerController(IStarWarsStoreBL p_starwarsBL){
            _starWarsBL = p_starwarsBL;
        }

        // GET: api/Customer
        [HttpGet("GetAll")]
        public IActionResult GetAllCustomers()
        {
            Log.Information("User is attempting to retrieve all customers.");
            try
            {
                Log.Information("User successfully retrieved all customers.");
                return Ok(_starWarsBL.GetAllCustomer());
            }
            catch (SqlException)
            {
                Log.Information("User failed to retrieve all customers.");
                return NotFound();
            }
        }

        // GET: api/Customer/5
        [HttpGet("CustomerLogin")]
        public IActionResult Get(string _userName, string _password){
        Log.Information("User is attempting to login as a select customer.");
        try
        {
            Log.Information("User is successful at logging in under a set customer.");
            return Ok(_starWarsBL.CustomerLogin(_userName, _password));
        }
        catch (SqlException)
        {
            Log.Information("User failed to login as a set customer.");
            return NotFound();
        }
    }

        // POST: api/Customer
        [HttpPost("AddCustomer")]
        public IActionResult Post([FromBody] Customer n_customer)
        {
            Log.Information("User is attempting to add a new customer.");
            try
            {
                Log.Information("User was successful at Adding a new customer.");
                return Ok(_starWarsBL.AddCustomer(n_customer));
            }
            catch (SqlException)
            {
                Log.Information("User failed to add a new customer.");
                return Conflict();
            }
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
