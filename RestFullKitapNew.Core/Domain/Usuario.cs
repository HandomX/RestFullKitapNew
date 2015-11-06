using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Core.Domain
{
    public class Usuario : IdentityUser
    {
        public string NomeCompleto { get; private set; }
        public string ImageLink { get; private set; }
        public string Descricao { get; private set; }

        public virtual ICollection<Exemplar> Exemplares { get; private set; }

        private Usuario()
        {

        }

        public static Usuario Criar(string userName, string email, string nomeCompleto, string imageLink, string descricao, string telefone)
        {
            var usuario = new Usuario()
            {
                UserName = userName,
                Email = email,
                NomeCompleto = nomeCompleto,
                ImageLink = imageLink,
                Descricao = descricao,
                PhoneNumber = telefone

            };

            return usuario;
        }
    }
}
