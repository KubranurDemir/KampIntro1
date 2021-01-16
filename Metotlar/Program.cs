using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 }; // ürün dizisi oluşturduk. urun1,urun2 bilgisi genelde veri kaynağından gelir.

            foreach (var urun in urunler) // in urunler- ürünler dizisinin her bir elemanını tek tek gez, ortadaki urun her döngüde yer alan elemana takma isim veriyoruz. En baştaki Urun=veri tipi dir. 
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");

            }

            Console.WriteLine("-------Metotlar---------");

            // classı çağırırken 
            // encapsulation 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 5);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);


        }
    }
}
