using Rehber.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entities.Mapping
{
    public class KisiMapping: EntityTypeConfiguration<Kisi>
    {
        public KisiMapping()
        {
            Property(x => x.KisiAdi)
                .HasMaxLength(50)
                .IsRequired();
            Property(x => x.KisiSoyadi)
                .HasMaxLength(50)
                .IsRequired();
            Property(x => x.KisiYas)
                .IsRequired();
        }
    }
}
