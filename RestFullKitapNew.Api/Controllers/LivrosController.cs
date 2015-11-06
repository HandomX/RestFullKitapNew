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

        [Route("")]
        [HttpGet]
        public HttpResponseMessage TodosLivros()
        {
            var livros = new AcervoCentral().TodosLivros();

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);

            return response;
        }

        [Route("")]
        [HttpGet]
        public HttpResponseMessage LivrosPorISBN(string isbn)
        {
            var livro = new AcervoCentral().LivroPorISBN(isbn);
            
            var response = Request.CreateResponse(HttpStatusCode.Accepted, livro);

            return response;
        }

        [Route("")]
        [HttpGet]
        public HttpResponseMessage LivrosPorTitulo(string titulo)
        {
            var livros = new AcervoCentral().LivrosPorTitulo(titulo);

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);
            

            return response;
        }

        [Route("")]
        [HttpGet]
        public HttpResponseMessage LivrosPorAutor(string autor)
        {
            var livros = new AcervoCentral().LivrosPorAutor(autor);

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);

            return response;
        }

        [Route("")]
        [HttpGet]
        public HttpResponseMessage LivrosPorEditora(string editora)
        {
            var livros = new AcervoCentral().LivrosPorEditora(editora);

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);

            return response;
        }

        [Route("")]
        [HttpGet]
        public HttpResponseMessage LivrosPorCategoria(string categoria)
        {
            var livros = new AcervoCentral().LivrosPorCategoria(categoria);

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);

            return response;
        }

        [Route("{isbn}/exemplares")]
        [HttpGet]
        public HttpResponseMessage ExemplaresDoLivro([FromUri]string isbn)
        {
            var livros = new AcervoCentral().ExemplaresPorISBN(isbn);

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);

            return response;
        }
    }
}
