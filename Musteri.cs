using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class Musteri
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }

        public Musteri(int id, string ad, string soyad)
        {
            this.id = id;
            this.ad = ad;
            this.soyad = soyad;
        }
    }
}
