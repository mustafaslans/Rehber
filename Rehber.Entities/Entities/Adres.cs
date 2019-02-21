using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entities.Entities
{
    public class Adres
    {
        [Key]
        public int AdresID { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public int KisiID { get; set; }
        public virtual Kisi Kisi { get; set; }
    }
}
