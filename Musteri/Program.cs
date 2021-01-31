using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 101;
            musteri1.Ad = "Elif";
            musteri1.Soyad = "Oğuzkan";
            musteri1.Bakiye = 112.5;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 102;
            musteri2.Ad = "Aysun";
            musteri2.Soyad = "Orhan";
            musteri2.Bakiye = 500;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 103;
            musteri3.Ad = "İpek";
            musteri3.Soyad = "Gentek";
            musteri3.Bakiye = 112.5;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 104;
            musteri4.Ad = "Gamze";
            musteri4.Soyad = "Fidan";
            musteri4.Bakiye = 275.9;

            Musteri [] musteriler = new Musteri[] { musteri1, musteri2, musteri3};
            Console.WriteLine("Müşteri Listesi");

            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Bakiye);
                Console.WriteLine("------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4);
            musteriManager.Sil(musteri2);

        }
    }
}
