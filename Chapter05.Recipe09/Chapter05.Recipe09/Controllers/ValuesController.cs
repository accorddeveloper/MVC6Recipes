using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Chapter05.Recipe09.Controllers
{
    /// <summary>
    /// This is a comment that describes this entire controller
    /// </summary>
    [Authorize]
    public class ValuesController : ApiController
    {
        /// <summary>
        /// This is a sample.
        /// </summary>
        /// <returns>Returns a list of string. Will always be the same result.</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// This is a sample summary for the GET method
        /// </summary>
        /// <param name="id">An integer that represents the id of the item you want to get</param>
        /// <returns>the string "value"</returns>
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
