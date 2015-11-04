using RestFullKitapNew.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.DB.Map
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {

        public CategoriaMap()
        {
            ToTable("Categorias");

            Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("Nome");
                
        }
    }
}
