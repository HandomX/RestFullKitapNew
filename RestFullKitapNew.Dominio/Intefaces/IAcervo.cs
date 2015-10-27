using RestFullKitapNew.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Core.Services
{
    public interface IAcervo : IPesquisaAcervo
    {
        bool Adcionar(Exemplar exemplar);
        Exemplar Remover(int exemplarID);
    }
}
