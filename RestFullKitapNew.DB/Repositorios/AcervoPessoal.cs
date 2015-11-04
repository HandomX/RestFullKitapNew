using RestFullKitapNew.Core.Domain;
using RestFullKitapNew.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.DB.Repositorios
{
    public class AcervoPessoal : IAcervo<Exemplar>
    {
        private KitapContext _KitapDB;

        public AcervoPessoal()
        {
            _KitapDB = new KitapContext();
        }

        public bool Adcionar(Exemplar objeto)
        {
            var exemplares = _KitapDB.Exemplares;
            
            exemplares.Add(objeto);

            _KitapDB.SaveChanges();

            return true;
        }

        public Exemplar Remover(Exemplar exemplar)
        {
            var exemplares = _KitapDB.Exemplares;

            exemplares.Remove(exemplar);

            _KitapDB.SaveChanges();

            return exemplar;
        }

        public List<Exemplar> Todos()
        {
            var exemplares = _KitapDB.Exemplares;

            return exemplares.ToList<Exemplar>();
        }

        public List<Exemplar> PorTitulo(string titulo)
        {
            throw new NotImplementedException();
        }

        public List<Exemplar> PorEditora(string editora)
        {
            throw new NotImplementedException();
        }

        public List<Exemplar> PorAutor(string autor)
        {
            throw new NotImplementedException();
        }

        public List<Exemplar> PorCategoria(string categoria)
        {
            throw new NotImplementedException();
        }
    }
}
