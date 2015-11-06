using Newtonsoft.Json;
using RestFullKitapNew.Core.Domain.TiposAuxliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RestFullKitapNew.Core.Domain
{
    public class Livro
    {
        public string Isbn { get; private set; }
        public string ImagemLink { get; private set; }
        public string Titulo { get; private set; }
        public string Autores { get; private set; }
        public string Editora { get; private set; }
        public string Descricao { get; private set; }
        public int Paginas { get; private set; }
        public int CategoriaID { get; private set; }

        
        public Categoria Categoria { get; set; }
        
        public ICollection<Exemplar> Exemplares { get; set; }


        private Livro()
        {

        }

        public static Livro Criar(string isbn, string imagemLink, string titulo, string autores, string editora, string descricao, int paginas, int categoriaID)
        {
            var livro = new Livro()
            {
                Isbn = isbn,
                ImagemLink = imagemLink,
                Titulo = titulo,
                Autores = autores,
                Editora = editora,
                Descricao = descricao,
                Paginas = paginas,
                CategoriaID = categoriaID
            };

            return livro;
        }


    }
}
