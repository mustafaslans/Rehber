using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class AdresViewModel
    {
        [Key]
        public int AdresID { get; set; }
        [Required(ErrorMessage ="İl alanı boş geçilemez")]
        [MaxLength(20,ErrorMessage ="Maximum 20 karakter")]
        public string Il { get; set; }
        [Required(ErrorMessage = "İlçe alanı boş geçilemez")]
        [MaxLength(20, ErrorMessage = "Maximum 20 karakter")]
        public string Ilce { get; set; }
        public int KisiID { get; set; }
    }
}