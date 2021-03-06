﻿using RestFullKitapNew.Api.App_Start;
using RestFullKitapNew.Api.Identity;
using RestFullKitapNew.Api.Models;
using RestFullKitapNew.DB.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RestFullKitapNew.Api.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        private UsuarioAuthRepositorio repoUser;
        private AcervoCentral repoAcervoCentral;

        public UsuarioController()
        {
            repoUser = new UsuarioAuthRepositorio();
            repoAcervoCentral = new AcervoCentral();
        }

        [Route("{nameUser}")]
        [HttpGet]
        public async Task<HttpResponseMessage> InformacoesUsuario([FromUri]string nameUser)
        {
            var usuario = await repoUser.BuscarUserPorNome(nameUser);

            var response = Request.CreateResponse(HttpStatusCode.Accepted, usuario);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            return response;
        }

        [Route("{nameUser}/exemplar")]
        [HttpPost]
        public HttpResponseMessage Adicionar([FromUri]string nameUser, ExemplarCadastroModel exemplarModel)
        {
            
            if (ModelState.IsValid)
            {
                

                var livro = MapConfig.GetLivro(exemplarModel.Livro);
                var exemplar = MapConfig.GetExemplar(exemplarModel);

                repoAcervoCentral.Adcionar(exemplar, livro);

                var response = Request.CreateResponse(HttpStatusCode.Created, exemplar);
                response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
                return response;
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, new { mensagem = "modelo invalido" });
        }

        [Route("{nameUser}/exemplares")]
        [HttpGet]
        public HttpResponseMessage TodosExemplares([FromUri] string nameUser)
        {
            var exemplares = MapConfig.GetExemplaresInformacoes(repoAcervoCentral.TodosExemplares(nameUser));

            var response = Request.CreateResponse(HttpStatusCode.Accepted, exemplares);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            return response;
        }

        //[HttpGet]
        //[Route("{nameUser}/exemplares")]
        //public HttpResponseMessage ExemplaresPorISBN([FromUri]string nameUser, string isbn)
        //{
        //    var livros = MapConfig.GetExemplaresInformacoes(repoAcervoCentral.ExemplaresPorISBN(nameUser, isbn));

        //    var response = Request.CreateResponse(HttpStatusCode.Accepted, livros);

        //    return response;
        //}

        [Route("{nameUser}/exemplares")]
        [HttpGet]
        public HttpResponseMessage ExemplaresPorTitulo([FromUri]string nameUser, string titulo)
        {
            var exemplares = MapConfig.GetExemplaresInformacoes(repoAcervoCentral.ExemplaresPorTitulo(nameUser, titulo));

            var response = Request.CreateResponse(HttpStatusCode.Accepted, exemplares);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            return response;
        }

        [Route("{nameUser}/exemplares")]
        [HttpGet]
        public HttpResponseMessage ExemplaresPorAutor([FromUri]string nameUser, string autor)
        {
            var exemplares = MapConfig.GetExemplaresInformacoes(repoAcervoCentral.ExemplaresPorAutor(nameUser, autor));

            var response = Request.CreateResponse(HttpStatusCode.Accepted, exemplares);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            return response;
        }

        [Route("{nameUser}/exemplares")]
        [HttpGet]
        public HttpResponseMessage ExemplaresPorEditora([FromUri]string nameUser, string editora)
        {
            var exemplares = MapConfig.GetExemplaresInformacoes(repoAcervoCentral.ExemplaresPorEditora(nameUser, editora));

            var response = Request.CreateResponse(HttpStatusCode.Accepted, exemplares);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            return response;
        }

        [Route("{nameUser}/exemplares")]
        [HttpGet]
        public HttpResponseMessage ExemplaresPorCategoria([FromUri]string nameUser, string categoria)
        {
            var exemplares = MapConfig.GetExemplaresInformacoes(repoAcervoCentral.ExemplaresPorCategoria(nameUser, categoria));

            var response = Request.CreateResponse(HttpStatusCode.Accepted, exemplares);
            response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            
            return response;
        }

        
    }
}
