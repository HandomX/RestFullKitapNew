using RestFullKitapNew.Api.App_Start;
using RestFullKitapNew.Api.Models;
using RestFullKitapNew.DB.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestFullKitapNew.Api.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        [Route("{nameUser}")]
        [HttpGet]
        public HttpResponseMessage InformacoesUsuario([FromUri]string nameUser)
        {
            var exemplares = new AcervoCentral().TodosExemplares();

            var response = Request.CreateResponse(HttpStatusCode.Accepted, new { mensage = "Informações do Usuario" });

            return response;
        }

        [Route("{nameUser}/exemplar")]
        [HttpPost]
        public HttpResponseMessage Adicionar([FromUri]string nameUser, ExemplarModel exemplarModel)
        {
            if (ModelState.IsValid)
            {
                var acervoCentral = new AcervoCentral();

                var livro = MapConfig.GetLivro(exemplarModel.Livro);
                var exemplar = MapConfig.GetExemplar(exemplarModel);

                acervoCentral.Adcionar(exemplar, livro);

                var response = Request.CreateResponse(HttpStatusCode.Created, exemplar);

                return response;
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, new { mensagem = "modelo invalido" });
        }

        [Route("{nameUser}/exemplares")]
        [HttpGet]
        public HttpResponseMessage TodosExemplares([FromUri] string nameUser)
        {
            var exemplares = new AcervoCentral().TodosExemplares();

            var response = Request.CreateResponse(HttpStatusCode.Accepted, exemplares);

            return response;
        }

        [HttpGet]
        [Route("{nameUser}/exemplares")]
        public HttpResponseMessage ExemplaresPorISBN([FromUri]string nameUser, string isbn)
        {
            var livros = new AcervoCentral().ExemplaresPorISBN(isbn);

            var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);

            return response;
        }

        [Route("{nameUser}/exemplares")]
        [HttpGet]
        public HttpResponseMessage ExemplaresPorTitulo([FromUri]string nameUser, string titulo)
        {
            var exemplares = new AcervoCentral().ExemplaresPorTitulo(titulo);

            var response = Request.CreateResponse(HttpStatusCode.Accepted, exemplares);

            return response;
        }

        [Route("{nameUser}/exemplares")]
        [HttpGet]
        public HttpResponseMessage ExemplaresPorAutor([FromUri]string nameUser, string autor)
        {
            var exemplares = new AcervoCentral().ExemplaresPorAutor(autor);

            var response = Request.CreateResponse(HttpStatusCode.Accepted, exemplares);

            return response;
        }

        [Route("{nameUser}/exemplares")]
        [HttpGet]
        public HttpResponseMessage ExemplaresPorEditora([FromUri]string nameUser, string editora)
        {
            var exemplares = new AcervoCentral().ExemplaresPorEditora(editora);

            var response = Request.CreateResponse(HttpStatusCode.Accepted, exemplares);

            return response;
        }

        [Route("{nameUser}/exemplares")]
        [HttpGet]
        public HttpResponseMessage ExemplaresPorCategoria([FromUri]string nameUser, string categoria)
        {
            var exemplares = new AcervoCentral().ExemplaresPorCategoria(categoria);

            var response = Request.CreateResponse(HttpStatusCode.Accepted, exemplares);

            return response;
        }

        
    }
}
