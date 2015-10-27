using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Core.Domain
{
    public class Pedido
    {
        public int ID { get; private set; }
        public int EmprestadorID { get; private set; }
        public int PedintiID { get; private set; }
        public int ExemplarID { get; private set; }


        public virtual Usuario Emprestador { get; private set; }
        public virtual Usuario Pedinti { get; private set; }
        public virtual Exemplar Exemplar { get; private set; }


        private Pedido()
        {

        }

        public static Pedido Fazer(int id, int emprestadorID, int pedintiID, int exemplarID)
        {
            var pedido = new Pedido()
            {
                ID = id,
                EmprestadorID = emprestadorID,
                PedintiID = pedintiID,
                ExemplarID = exemplarID
            };

            return pedido;
        }

        public void Confirma()
        {

        }

        public void Negar()
        {

        }

        public void Cancelar()
        {

        }

    }
}
