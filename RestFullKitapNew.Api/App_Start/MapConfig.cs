using RestFullKitapNew.Api.Models;
using RestFullKitapNew.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestFullKitapNew.Api.App_Start
{
    public class MapConfig
    {
        public static Exemplar GetExemplar(ExemplarCadastroModel exemplar)
        {
            return Exemplar.Criar(exemplar.UsuarioID, exemplar.LivroISBN, exemplar.Status);
        }

        public static Livro GetLivro(LivroCadastroModel livro)
        {
            return Livro.Criar(livro.Isbn, livro.ImagemLink, livro.Titulo,
                               livro.Autores, livro.Editora, livro.Descricao,
                               livro.Paginas, livro.CategoriaID);
        }

        public static ExemplarInformacaoModel GetExemplarInformacoes(Exemplar exemplar)
        {
            var exemplarModel = new ExemplarInformacaoModel()
            {
                ExemplarID = exemplar.ID,
                Livro = exemplar.Livro.Isbn,
                Usuario = exemplar.Usuario.UserName,
                Status = exemplar.Status.ToString()
            };

            return exemplarModel;
        }

        public static LivroInformacaoesModel GetLivroInformacoes(Livro livro)
        {
            var livroModel = new LivroInformacaoesModel()
            {
                Isbn = livro.Isbn,
                Titulo = livro.Titulo,
                Editora = livro.Editora,
                Categoria = livro.Categoria.Nome,
                Autores = livro.Autores,
                Descricao = livro.Descricao,
                ImagemLink = livro.ImagemLink,
                Paginas = livro.Paginas,
                Exemplares = livro.Exemplares.Count()
            };

            return livroModel;
        }

        public static List<LivroInformacaoesModel> GetLivrosInformacoes(List<Livro> livros)
        {
            var livrosModel = new List<LivroInformacaoesModel>();

            foreach(var l in livros)
            {
                livrosModel.Add(MapConfig.GetLivroInformacoes(l));
            }
            return livrosModel;
        }

        public static List<ExemplarInformacaoModel> GetExemplaresInformacoes(List<Exemplar> exemplares)
        {
            var exemplaresModel = new List<ExemplarInformacaoModel>();

            foreach (var e in exemplares)
            {
                exemplaresModel.Add(MapConfig.GetExemplarInformacoes(e));
            }
            return exemplaresModel;
        }
    }
}