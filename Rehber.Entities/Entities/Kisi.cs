using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entities.Entities
{
    public class Kisi
    {
        [Key]
        public int KisiID { get; set; }
        public string KisiAdi { get; set; }
        public string KisiSoyadi { get; set; }
        public int KisiYas { get; set; }
        public virtual ICollection<Adres> Adres { get; set; }

    }
}
