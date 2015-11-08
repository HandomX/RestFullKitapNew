using RestFullKitapNew.Core.Domain;
using RestFullKitapNew.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace RestFullKitapNew.DB.Repositorios
{
    public class AcervoCentral :  IDisposable
    {
        private KitapContext _KitapDB;

        public AcervoCentral()
        {
            _KitapDB = new KitapContext();
        }

        public bool Adcionar(Exemplar exemplar, Livro livro)
        {
            var livros = _KitapDB.Livros;
            var exemplares = _KitapDB.Exemplares;

            Livro livroAux = livros.Where(l => l.Isbn == livro.Isbn).FirstOrDefault();

            if (livroAux == null)
                livros.Add(livro);

            exemplares.Add(exemplar);

            _KitapDB.SaveChanges();

            return true;
        }
        
        public List<Livro> TodosLivros()
        {
            var livros = _KitapDB.Livros.Include(l => l.Categoria).Include(l => l.Exemplares);

            return livros.ToList<Livro>();
        }

        public Livro LivroPorISBN(string isbn)
        {
            var livro = _KitapDB.Livros.Include(l => l.Categoria).Include(l => l.Exemplares).Where(l => l.Isbn == isbn).FirstOrDefault();
            
            return livro;
        }

        public List<Livro> LivrosPorTitulo(string titulo)
        {
            var livros = _KitapDB.Livros.Include(l => l.Categoria).Include(l => l.Exemplares).Where(l => l.Titulo.Contains(titulo));

            return livros.ToList<Livro>();
        }

        public List<Livro> LivrosPorEditora(string editora)
        {
            var livros = _KitapDB.Livros.Include(l => l.Categoria).Include(l => l.Exemplares).Where(l => l.Editora.Contains(editora));

            return livros.ToList<Livro>();
        }

        public List<Livro> LivrosPorAutor(string autor)
        {
            var livros = _KitapDB.Livros.Include(l => l.Categoria).Include(l => l.Exemplares).Where(l => l.Autores.Contains(autor));

            return livros.ToList<Livro>();
        }

        public List<Livro> LivrosPorCategoria(string categoria)
        {
            var livros = _KitapDB.Livros.Include(l => l.Categoria).Include(l => l.Exemplares).Where(l => l.Categoria.Nome == categoria);

            return livros.ToList<Livro>();
        }

        public List<Exemplar> TodosExemplares()
        {
            var exemplares = _KitapDB.Exemplares.Include(l => l.Livro).Include(l => l.Usuario);

            return exemplares.ToList<Exemplar>();
        }

        public List<Exemplar> ExemplaresPorISBN(string isbn)
        {
            var exemplares = _KitapDB.Exemplares.Include(e => e.Livro).Include(e => e.Usuario).Where(e => e.Livro.Isbn == isbn);
            return exemplares.ToList<Exemplar>();
        }

        public List<Exemplar> ExemplaresPorTitulo(string titulo)
        {
            var exemplares = _KitapDB.Exemplares.Include(e => e.Livro).Include(e => e.Usuario).Where(e => e.Livro.Titulo == titulo);

            return exemplares.ToList<Exemplar>();
        }

        public List<Exemplar> ExemplaresPorAutor(string autor)
        {
            var exemplares = _KitapDB.Exemplares.Include(e => e.Livro).Include(e => e.Usuario).Where(e => e.Livro.Autores.Contains(autor));

            return exemplares.ToList<Exemplar>();
        }

        public List<Exemplar> ExemplaresPorEditora(string editora)
        {
            var exemplares = _KitapDB.Exemplares.Include(e => e.Livro).Include(e => e.Usuario).Where(e => e.Livro.Editora == editora);

            return exemplares.ToList<Exemplar>();
        }

        public List<Exemplar> ExemplaresPorCategoria(string categoria)
        {
            var exemplares = _KitapDB.Exemplares.Include(e => e.Livro).Include(e=> e.Livro.Categoria).Include(e => e.Usuario).Where(e => e.Livro.Categoria.Nome == categoria);

            return exemplares.ToList<Exemplar>();
        }

        public void Dispose()
        {
            _KitapDB.Dispose();
        }
    }
}
