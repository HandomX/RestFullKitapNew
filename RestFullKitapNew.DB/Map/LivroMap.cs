﻿using RestFullKitapNew.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.DB.Map
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {

        public LivroMap()
        {
            ToTable("Livros");

            Property(e => e.Isbn)
                .IsRequired()
                .HasColumnName("ISBN");

            Property(l => l.Titulo)
                .IsRequired()
                .HasColumnName("Titulo");

            Property(l => l.ImagemLink)
                .HasColumnName("ImagemLink");

            Property(l => l.Editora)
                .IsRequired()
                .HasColumnName("Editora");

            Property(l => l.Autores)
                .IsRequired()
                .HasColumnName("Autores");

            Property(l => l.Descricao)
                .HasColumnName("Descricao");

            Property(l => l.Paginas)
                .IsRequired()
                .HasColumnName("Paginas");

        }
    }
}
