using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Sınıflar
{
    public class Adres
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string AcikAdres { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }
    }
}