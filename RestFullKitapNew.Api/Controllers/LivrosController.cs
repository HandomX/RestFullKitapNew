using RestFullKitapNew.Api.App_Start;
using RestFullKitapNew.Core.Domain;
using RestFullKitapNew.DB.Repositorios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;


namespace RestFullKitapNew.Api.Controllers
{
    [RoutePrefix("api/livros")]
    public class LivrosController : ApiController
    {
        private AcervoCentral _acervoCentral;

        public LivrosController()
        {
            _acervoCentral = new AcervoCentral();
        }

        [Route("")]
        [HttpGet]
        public HttpResponseMessage TodosLivros()
        {

            var livros = MapConfig.GetLivrosInformacoes(_acervoCentral.TodosLivros());

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            return response;
        }

        [Route("")]
        [HttpGet]
        public HttpResponseMessage LivrosPorISBN(string isbn)
        {
            var livro = MapConfig.GetLivroInformacoes(_acervoCentral.LivroPorISBN(isbn));
            
            var response = Request.CreateResponse(HttpStatusCode.Accepted, livro);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            return response;
        }

        [Route("")]
        [HttpGet]
        public HttpResponseMessage LivrosPorTitulo(string titulo)
        {
            var livros = MapConfig.GetLivrosInformacoes(_acervoCentral.LivrosPorTitulo(titulo));

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            return response;
        }

        [Route("")]
        [HttpGet]
        public HttpResponseMessage LivrosPorAutor(string autor)
        {
            var livros = MapConfig.GetLivrosInformacoes(_acervoCentral.LivrosPorAutor(autor));

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            return response;
        }

        [Route("")]
        [HttpGet]
        public HttpResponseMessage LivrosPorEditora(string editora)
        {
            var livros = MapConfig.GetLivrosInformacoes(_acervoCentral.LivrosPorEditora(editora));

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            return response;
        }

        [Route("")]
        [HttpGet]
        public HttpResponseMessage LivrosPorCategoria(string categoria)
        {
            var livros = MapConfig.GetLivrosInformacoes(_acervoCentral.LivrosPorCategoria(categoria));

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            return response;
        }

        [Route("{isbn}/exemplares")]
        [HttpGet]
        public HttpResponseMessage ExemplaresDoLivro([FromUri]string isbn)
        {
            var livros = MapConfig.GetExemplaresInformacoes(_acervoCentral.ExemplaresPorISBN(isbn));

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            return response;
        }
    }
}
