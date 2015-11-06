using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestFullKitapNew.Api.Models
{
    public class UserCadastroModel
    {
        [Required]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required]
        [Display(Name = "Nome de Usuario")]
        public string NomeDeUsuario { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ser , pelo menos, {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmação Senha")]
        [Compare("Senha")]
        public string ConfirmacaoSenha { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Display(Name = "Imagem de Usuario")]
        public string ImageLink { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}