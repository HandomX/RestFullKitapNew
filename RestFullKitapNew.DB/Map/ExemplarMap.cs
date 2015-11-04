using RestFullKitapNew.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.DB.Map
{
    public class ExemplarMap : EntityTypeConfiguration<Exemplar>
    {

        public ExemplarMap()
        {

            ToTable("Exemplares");

            Property(e => e.Status)
                .IsRequired()
                .HasColumnName("Status");
        }
    }
}
