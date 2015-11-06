using RestFullKitapNew.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.DB.Map
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuarios");

            Property(u => u.NomeCompleto)
                .HasColumnName("NomeCompleto")
                .IsRequired();

            Property(u => u.ImageLink)
                .HasColumnName("ImageLink");

            Property(u => u.PhoneNumber)
                .HasColumnName("Telefone")
                .IsRequired();

            Property(u => u.Descricao)
                .HasColumnName("Descricao");

            

        }
    }
}
