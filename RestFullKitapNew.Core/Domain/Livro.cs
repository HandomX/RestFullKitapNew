using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Core.Domain
{
    public class Livro
    {
        public ISBN ISBN { get; private set; }
        public string ImagemLink { get; private set; }
        public string Titulo { get; private set; }
        public Autores Autores { get; private set; }
        public string Editora { get; private set; }
        public string Descricao { get; private set; }
        public int Paginas { get; private set; }
        public int CategoriaID { get; private set; }
        


        private Livro()
        {

        }

        public static Livro Criar(ISBN isbn, string imagemLink, string titulo, Autores autores, string editora, string descricao, int paginas, int categoriaID)
        {
            var livro = new Livro()
            {
                ISBN = isbn,
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
