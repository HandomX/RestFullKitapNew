using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Api.Models
{
    public class LivroInformacaoesModel
    {
        public string Isbn { get; set; }
        public string ImagemLink { get; set; }
        public string Titulo { get; set; }
        public string Autores { get; set; }
        public string Editora { get; set; }
        public string Descricao { get; set; } 
        public int Paginas { get; set; }  
        public string Categoria { get; set; }
        public int Exemplares { get; set; }
    }
}
