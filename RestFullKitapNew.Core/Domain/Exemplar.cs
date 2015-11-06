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
    public class Exemplar
    {
        public int ID { get; private set; }
        public string UsuarioID { get; private set; }
        public string LivroISBN { get; private set; }
        public Status Status { get; set; }

        [JsonIgnore]
        public virtual Livro Livro { get; private set; }

        public virtual Usuario Usuario { get; private set; }

        private Exemplar()
        {

        }

        public static Exemplar Criar(string usuarioID, string livroISBN, Status status)
        {
            var exemplar = new Exemplar()
            {
                UsuarioID = usuarioID,
                LivroISBN = livroISBN,
                Status = status
            };

            return exemplar;
        }

        public static Exemplar Criar(int id, string usuarioID, string livroISBN, Status status)
        {
            var exemplar = new Exemplar()
            {
                ID = id,
                UsuarioID = usuarioID,
                LivroISBN = livroISBN,
                Status = status
            };

            return exemplar;
        }
    }
}
