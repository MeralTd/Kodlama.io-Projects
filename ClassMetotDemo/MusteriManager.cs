using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " müşterisi eklendi.");
            Console.WriteLine();
        }

        

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listesi");
            Console.WriteLine();

            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine("Müşteri Adi: ", musteriler[i].Adi);
                Console.WriteLine("Müşteri Soyadi: ", musteriler[i].Soyadi);
                Console.WriteLine("-------------------------------");
            }

        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " müşterisi silindi.");
            Console.WriteLine();
        }
        
    }
}
