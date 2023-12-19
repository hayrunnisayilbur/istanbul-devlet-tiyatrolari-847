using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace istanbul_devlet_tiyatrosu_847
{
    internal class Tiyatro
    {
        public int Id { get; set; }
        public string OyunAd { get; set; }
        public string Sahne { get; set; }
        public DateTime Tarih { get; set; }
        public int Sure { get; set; }
        public double Fiyat { get; set; }
        public bool Muzikal { get; set; }

        public Tiyatro(int id, string oyunAd, string sahne, DateTime tarih, int sure, double fiyat, bool muzikal)
        {
            Id = id;
            OyunAd = oyunAd;
            Sahne = sahne;
            Tarih = tarih;
            Sure = sure;
            Fiyat = fiyat;
            Muzikal = muzikal;
            
        }
    }
}
