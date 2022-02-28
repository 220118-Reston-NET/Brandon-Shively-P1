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
    public class LineItemsController : ControllerBase
    {
        private IStarWarsStoreBL _starWarsBL;
        public LineItemsController(IStarWarsStoreBL p_starWarsBL){
            _starWarsBL = p_starWarsBL;
        }
        // GET: api/LineItems
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LineItems/5
        [HttpGet("GetLineItems")]
        public IActionResult GetLineItems(int StoreID)
        {
            try
            {
                return Ok(_starWarsBL.GetAllLineItems(StoreID));
            }
            catch (SqlException)
            {
                return NotFound();
            }
        }

        // POST: api/LineItems
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/LineItems/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/LineItems/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
