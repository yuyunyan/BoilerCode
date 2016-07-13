using BoilerCode.Models.Responses;
using BoilerCode.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BoilerCode.Controllers.Api
{
    [RoutePrefix("api/cat")]
    public class CategoriesApiController : ApiController
    {
        [Route("getCats"),HttpGet]
        public HttpResponseMessage ListCat()
        {
            ItemsResponse<Domain.Categories> response = new ItemsResponse<Domain.Categories>();
            response.Items = CategorieService.ListCategories();

            return Request.CreateResponse(response);

        }

    }
}
