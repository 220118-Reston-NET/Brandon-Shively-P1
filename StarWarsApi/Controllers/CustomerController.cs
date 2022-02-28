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
            try
            {
                return Ok(_starWarsBL.GetAllCustomer());
            }
            catch (SqlException)
            {
                return NotFound();
            }
        }

        // GET: api/Customer/5
        [HttpGet("CustomerLogin")]
        public IActionResult Get(string _userName, string _password){
        try
        {
            return Ok(_starWarsBL.CustomerLogin(_userName, _password));
        }
        catch (SqlException)
        {
            return NotFound();
        }
    }

        // POST: api/Customer
        [HttpPost("AddCustomer")]
        public IActionResult Post([FromBody] Customer n_customer)
        {
            try
            {
                return Ok(_starWarsBL.AddCustomer(n_customer));
            }
            catch (SqlException)
            {
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
