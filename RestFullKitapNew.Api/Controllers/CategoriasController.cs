using RestFullKitapNew.Core.Domain;
using RestFullKitapNew.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestFullKitapNew.Api.Controllers
{
    public class CategoriasController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Todas()
        {
            var categorias = new KitapContext().Categorias.ToList<Categoria>();
            var response = Request.CreateResponse(HttpStatusCode.Accepted, categorias);

            return response;
        }
    }
}
