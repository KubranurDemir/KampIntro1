using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            
            // array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs","Java","Pyhton","C#"};


            for (int i = 0; i < kurslar.Length; i++)     // 1 den başla 10dan küçük olduğu sürece çalış ve 1,1 arttır. ++ demek 1,1 arttır demektir. i=i+2 2,2 arttır demek olurdu. Kurslar.lenght=uzunluğu kadar
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)  // foreach dizi temelli yapıları tek tek dönmeye yarar - Kursları(dizi) tek tek dolaş, kurs:her bir elemanın takma adı gibi düşün. 
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("sayfa sonu - footer");

        }
    }
}
