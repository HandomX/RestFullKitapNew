using RestFullKitapNew.Core.Domain.TiposAuxliares;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestFullKitapNew.Api.Models
{
    public class ExemplarCadastroModel 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o id do usuario que tem este exemplar.")]

        public string UsuarioID { get; set; }
        [Required(ErrorMessage = "Informe a qual livro este exemplar pertence.")]
        public string LivroISBN { get; set; }
        public Status Status { get; set; }
        [Required(ErrorMessage = "Informe os dados do livro do exemplar.")]
        public LivroCadastroModel Livro { get; set; }
    }
}