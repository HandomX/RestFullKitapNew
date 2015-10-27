using RestFullKitapNew.Core.Domain.TiposAuxliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Core.Domain
{
    public class Emprestimo
    {
        public int ID { get; private set; }
        public int PedidoID { get; private set; }
        public DateTime InicioEmprestimo { get; private set; }
        public DateTime FimEmprestimo { get; private set; }
        public Status Status { get; set; }

        public virtual Pedido Pedido { get; private set; }

        private Emprestimo()
        {

        }

        public static Emprestimo Iniciar(int id, int pedidoID, IntervaloDeData periodoDeEmprestimo)
        {
            var emprestimo = new Emprestimo()
            {
                ID = id,
                PedidoID = pedidoID,
                InicioEmprestimo = periodoDeEmprestimo.DataInicio,
                FimEmprestimo = periodoDeEmprestimo.DataFinal
            };

            return emprestimo;

        }
    }
}
