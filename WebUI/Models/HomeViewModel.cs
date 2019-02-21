using Rehber.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class HomeViewModel
    {
        public ICollection<Adres> Adres { get; set; }
        public ICollection<Kisi> Kisi { get; set; }
    }
}