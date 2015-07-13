using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Recipe03.LegacyWebApi.Models;

namespace Recipe03.LegacyWebApi.Controllers
{
    public class CellPhoneController : ApiController
    {
        public HttpResponseMessage GetPhones()
        {
            return Request.CreateResponse(HttpStatusCode.OK, GetPhoneManager.GetPhones());
        }
    }
}
