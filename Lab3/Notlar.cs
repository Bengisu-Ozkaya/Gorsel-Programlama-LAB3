using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Notlar
    {
        public int sinav1;
        public int sinav2;
        public int sinav3;
        public double ortalama;

        public double OrtalamaHesapla()
        {
            return Convert.ToDouble(sinav1 + sinav2 + sinav3) / 3;
        }
    }
}
