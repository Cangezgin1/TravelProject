using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Sınıflar
{
    public class BlogYorum
    {
        // Bu şekilde(IEnumerable) bir viewda birden fazla tablodan veri çekebileceğiz.
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
    }
}