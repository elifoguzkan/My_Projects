using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Eklendi: "  + musteri.Id + musteri.Ad + musteri.Soyad + musteri.Bakiye );
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi: " +musteri.Id + musteri.Ad + musteri.Soyad + musteri.Bakiye);
        }
    }
}
