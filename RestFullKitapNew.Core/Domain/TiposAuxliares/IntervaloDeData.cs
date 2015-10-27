using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Core.Domain.TiposAuxliares
{
    public class IntervaloDeData
    {
        public DateTime DataFinal { get; private set; }
        public DateTime DataInicio { get; private set; }

        public static IntervaloDeData Novo(DateTime dataDeInicio, DateTime dataDeFim)
        {
            var intevalo = new IntervaloDeData()
            {
                DataInicio = dataDeInicio,
                DataFinal = dataDeFim
            };

            return intevalo;
        }
    }
}
