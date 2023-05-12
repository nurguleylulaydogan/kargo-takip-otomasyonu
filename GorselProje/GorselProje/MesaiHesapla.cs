using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProje
{
    public class MesaiHesapla
    {
        public static string Ad;   //Static değişken
        public static string Soyad;
        public static int Tc;

        public static int hesapla(int saat, int saatbasitutar)   //Static metot
        {
            int tutar;
            tutar = saat * saatbasitutar;
            return tutar;
        }

        
    }
}
