using RestFullKitapNew.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Core.Services
{
    public interface IPesquisaAcervo<T>
    {
        List<T> Todos();
        List<T> PorTitulo(string titulo);
        List<T> PorEditora(string editora);
        List<T> PorAutor(string autor);
        List<T> PorCategoria(string categoria);
    }
}
