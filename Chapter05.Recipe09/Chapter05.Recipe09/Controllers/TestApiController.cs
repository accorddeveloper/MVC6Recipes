using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Chapter05.Recipe09.Controllers
{
    /// <summary>
    /// This is a test API that will show how docs work
    /// </summary>
    public class TestApiController : ApiController
    {
        [Route("api/test")]
        /// <summary>
        /// Gets all the tests created so far
        /// </summary>
        public IEnumerable<string> GetTests()
        {
            return new string[] { "test1", "test2", "test3" };

        }

        [Route("api/test")]
        /// <summary>
        /// Adds a new test
        /// </summary>
        public HttpResponseMessage PostTests()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "test4");

        }

        [Route("api/test")]
        /// <summary>
        /// Updates a test
        /// </summary>
        public HttpResponseMessage PutTests(string test)
        {
            return Request.CreateResponse(HttpStatusCode.OK, "test4");

        }
    }
}