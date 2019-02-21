using Rehber.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entities.Mapping
{
    public class AdresMapping : EntityTypeConfiguration<Adres>
    {
        public AdresMapping()
        {
            Property(x => x.Il)
                .HasMaxLength(50)
                .IsRequired();
            Property(x => x.Ilce)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
