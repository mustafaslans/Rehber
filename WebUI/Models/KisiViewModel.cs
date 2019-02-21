using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class KisiViewModel
    {
        [Key]
        public int KisiID { get; set; }
        [Required(ErrorMessage = "İsim alanı boş geçilemez")]
        [MaxLength(25, ErrorMessage = "Maximum 25 karakter")]
        public string KisiAdi { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        [MaxLength(25, ErrorMessage = "Maximum 25 karakter")]
        public string KisiSoyadi { get; set; }
        [Required(ErrorMessage = "Yaş alanı boş geçilemez")]
        [Range(10,60, ErrorMessage = "Yaş 10 ile 60 arasında olmalıdır")]
        public int KisiYas { get; set; }
    }
}