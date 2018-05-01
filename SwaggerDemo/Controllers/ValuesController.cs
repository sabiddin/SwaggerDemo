using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        // GET api/values
        /// <summary>
        /// Get is the default action of Values controller that will take nothing but gives back everything.
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        /// <summary>
        /// This overload of Get takes an ID and gives back the value.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        /// <summary>
        /// This post method takes a value and do nothing with it.
        /// </summary>
        /// <param name="value"></param>
        // POST api/values
        /// <remarks>
        /// Sample request:
        ///
        ///     POST 
        ///     {        
        ///        "value": "Something"        
        ///     }
        ///
        /// </remarks>
        /// <param name="value"></param>
        /// <returns>A newly created TodoItem</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response> 
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        /// <summary>
        /// This put action takes and id and replaces the value of that field that is present with that id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        /// <summary>
        /// deletes the record located in the specific id.
        /// </summary>
        /// <param name="id"></param>
        /// <remarks>
        ///     Delete 
        ///     {
        ///        "id": 1      
        ///     }
        /// </remarks>
        /// <response code="201">Deletes an item</response>
        /// <response code="400">If the item is null</response>  
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }      
    }
}
