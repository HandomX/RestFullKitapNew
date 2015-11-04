namespace RestFullKitapNew.DB.Migrations
{
    using RestFullKitapNew.Core.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RestFullKitapNew.DB.KitapContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RestFullKitapNew.DB.KitapContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Categorias.AddOrUpdate(
                c => c.Nome,
                Categoria.Criar(1, "Administração"),
                Categoria.Criar(2, "Agropecuária"),
                Categoria.Criar(3, "Artes"),
                Categoria.Criar(4, "Audiolivro"),
                Categoria.Criar(5, "Autoajuda"),
                Categoria.Criar(6, "Ciências Biológicas"),
                Categoria.Criar(7, "Ciências Exatas"),
                Categoria.Criar(8, "Ciências Humanas e Sociais"),
                Categoria.Criar(9, "Contabilidade"),
                Categoria.Criar(10, "Cursos e Idiomas"),
                Categoria.Criar(11, "Dicionários e Manuais Convers."),
                Categoria.Criar(12, "Didáticos"),
                Categoria.Criar(13, "Direito"),
                Categoria.Criar(14, "Economia"),
                Categoria.Criar(15, "Engenharia e Tecnologia"),
                Categoria.Criar(16, "Esoterismo"),
                Categoria.Criar(17, "Espiritualismo"),
                Categoria.Criar(18, "Esportes e Lazer"),
                Categoria.Criar(19, "Gastronomia"),
                Categoria.Criar(20, "Geografia e Historia"),
                Categoria.Criar(21, "Informática"),
                Categoria.Criar(22, "Linguística"),
                Categoria.Criar(23, "Literatura Estrangeira"),
                Categoria.Criar(24, "Literatura Infantojuvenil"),
                Categoria.Criar(25, "Literatura Nacional"),
                Categoria.Criar(26, "Livros"),
                Categoria.Criar(27, "Medicina"),
                Categoria.Criar(28, "Psicologia"),
                Categoria.Criar(29, "Religião"),
                Categoria.Criar(30, "Turismo")
                );
        }
    }
}
