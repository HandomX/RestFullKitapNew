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
        public static Exemplar GetExemplar(ExemplarModel exemplar)
        {
            return Exemplar.Criar(exemplar.UsuarioID, exemplar.LivroISBN, exemplar.Status);
        }

        public static Livro GetLivro(LivroModel livro)
        {
            return Livro.Criar(livro.Isbn, livro.ImagemLink, livro.Titulo,
                               livro.Autores, livro.Editora, livro.Descricao,
                               livro.Paginas, livro.CategoriaID);
        }
    }
}