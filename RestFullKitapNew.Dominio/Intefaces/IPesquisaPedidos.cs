using RestFullKitapNew.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Core.Services
{
    public interface IPesquisaPedidos
    {
        ICollection<Pedido> Todos();
        ICollection<Pedido> TodosConfirmados();
        ICollection<Pedido> TodosNegados();
        ICollection<Pedido> TodosCancelados();
        ICollection<Pedido> TodosPedentes();
        
    }
}
