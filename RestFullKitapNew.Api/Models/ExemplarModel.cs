using RestFullKitapNew.Core.Domain.TiposAuxliares;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestFullKitapNew.Api.Models
{
    public class ExemplarModel 
    {
        public int Id { get; set; }
        [Required]
        public int UsuarioID { get; set; }
        [Required(ErrorMessage = "Informe a qual livro este exemplar pertence")]
        public string LivroISBN { get; set; }
        public Status Status { get; set; }
        public LivroModel Livro { get; set; }
    }
}