using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Ogrenci
    {
        private string ad;
        private string soyad;
        private string ders;

        public string Ders { get => ders; set => ders = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Ad { get => ad; set => ad = value; }
    }
}
