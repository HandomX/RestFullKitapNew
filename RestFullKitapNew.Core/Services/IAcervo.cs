using RestFullKitapNew.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Core.Services
{
    public interface IAcervo<T> : IPesquisaAcervo<T>
    {
        bool Adcionar(T objeto);
    }
}
