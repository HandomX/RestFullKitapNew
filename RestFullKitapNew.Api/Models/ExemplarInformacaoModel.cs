using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestFullKitapNew.Api.Models
{
    public class ExemplarInformacaoModel
    {
        public int ExemplarID { get; set; }
        public string Livro { get; set; }
        public string Usuario { get; set; }
        public string Status { get; set; }
    }
}