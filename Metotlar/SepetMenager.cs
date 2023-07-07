using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetMenager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi:  "+urun.Adi);
        }
        public void Ekle2(string urunAdi, string urunaciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi:  " + urunAdi);
        }
    }
}
