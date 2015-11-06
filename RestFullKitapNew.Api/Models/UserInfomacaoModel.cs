using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestFullKitapNew.Api.Models
{
    public class UserInfomacaoModel
    {

        
        public string Id { get; set; }

        public string NomeCompleto { get; set; }
        
        public string NomeDeUsuario { get; set; }

        public string Email { get; set; }
        
        public string Telefone { get; set; }

        public string ImageLink { get; set; }

        public string Descricao { get; set; }

        
    }
}