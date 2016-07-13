using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BoilerCode.Controllers.Api
{
    public class TextApiController : ApiController
    {
        [RoutePrefix("api/cat")]
        public class CategoryController : ApiController
        {
           [Route("dog")]
            public IEnumerable<string> Get()
            {
                return new string[] { "value1", "value2" };
            }

            // GET api/<controller>/5
           
            public string Get(int id)
            {
                return "value";
            }


        }
    }
}

