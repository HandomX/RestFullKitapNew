using RestFullKitapNew.Core.Domain;
using RestFullKitapNew.DB.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.DB
{
    public class KitapContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Exemplar> Exemplares { get; set; }

        public KitapContext() : base("KitapConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new LivroMap());
            modelBuilder.Configurations.Add(new ExemplarMap());

            modelBuilder.Entity<Categoria>()
                .HasKey<int>(c => c.ID);

            modelBuilder.Entity<Livro>()
                .HasKey<string>(l => l.Isbn);

            modelBuilder.Entity<Exemplar>()
                .HasKey<int>(e => e.ID);


            modelBuilder.Entity<Livro>()
                .HasRequired<Categoria>(l => l.Categoria)
                .WithMany(c => c.Livros)
                .HasForeignKey(l => l.CategoriaID);

            modelBuilder.Entity<Exemplar>()
                .HasRequired<Livro>(e => e.Livro)
                .WithMany(l => l.Exemplares)
                .HasForeignKey(e => e.LivroISBN);

        }
    }
}
