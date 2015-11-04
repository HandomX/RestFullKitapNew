using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestFullKitapNew.Api.Models
{
    public class LivroModel
    {
        [Required(ErrorMessage ="Informe o ISBN do livro.")]
        public string Isbn { get; set; }
        public string ImagemLink { get; set; }
        [Required(ErrorMessage = "Informe o titulo do livro.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Informe o(s) autor(es) do livro.")]
        public string Autores { get; set; }
        [Required(ErrorMessage = "Informe a editora do livro")]
        public string Editora { get; set; }
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Informe a quantidade de paginas do livro.")]
        public int Paginas { get; set; }
        [Required(ErrorMessage = "Informe a categoria que o livro pertence")]
        public int CategoriaID { get; set; }
    }
}