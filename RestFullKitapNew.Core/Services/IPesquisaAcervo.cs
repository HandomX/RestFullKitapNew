using RestFullKitapNew.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Core.Services
{
    public interface IPesquisaAcervo
    {
        T Todos<T>();
        T PorTitulo<T>(string titulo);
        T PorUsuario<T>();
        T PorEditora<T>(string editora);
        T PorAutor<T>(string autor);
        T PorCategoria<T>(string categoria);
    }
}
