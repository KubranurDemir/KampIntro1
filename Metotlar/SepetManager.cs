using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) // büyük ürün tip, küçük ürün aşağıda kullanacağım isimlendirme
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urun.Adi);
        }
    }
}
