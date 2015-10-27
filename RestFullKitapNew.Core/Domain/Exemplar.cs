using RestFullKitapNew.Core.Domain.TiposAuxliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Core.Domain
{
    public class Exemplar
    {
        public int ID { get; private set; }
        public int UsuarioID { get; private set; }
        public int LivroID { get; private set; }
        public Status Status { get; set; }

        public virtual Livro Livro { get; private set; }

        private Exemplar()
        {

        }

        public static Exemplar Criar(int usuarioID, int livroID, Status status)
        {
            var exemplar = new Exemplar()
            {
                UsuarioID = usuarioID,
                LivroID = livroID,
                Status = status
            };

            return exemplar;
        }

        public static Exemplar Criar(int id, int usuarioID, Livro livro, Status status)
        {
            var exemplar = new Exemplar()
            {
                ID = id,
                UsuarioID = usuarioID,
                Livro = livro,
                Status = status
            };

            return exemplar;
        }
    }
}
