using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

        }
        private static bool MainMenu()
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Meral";
            musteri1.Soyadi = "Taşdemir";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "El";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1;
            musteri3.Adi = "Kadriye";
            musteri3.Soyadi = "Nur";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteri = new MusteriManager();
            Console.WriteLine("Bir seçenek seçin:");
            Console.WriteLine("1) Müsteri Ekle");
            Console.WriteLine("2) Müsteri Sil");
            Console.WriteLine("3) Müsterileri Listele");
            Console.WriteLine("4) Çıkış");
            Console.Write("\r\nBir seçenek seçin: ");

            switch (Console.ReadLine())
            {
                case "1":
                    musteri.Ekle(musteri1);
                    return true;
                case "2":
                    musteri.Sil(musteri2);
                    return true;
                case "3":
                    musteri.Listele(musteriler);
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }
    }
}
