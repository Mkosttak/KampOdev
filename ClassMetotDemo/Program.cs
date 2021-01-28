using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Isim = "Murat";
            musteri1.SoyIsim = "Kostak";
            musteri1.TC = 1234561;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Isim = "Ahmet";
            musteri2.SoyIsim = "Dikmen";
            musteri2.TC = 1234562;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Isim = "Enes";
            musteri3.SoyIsim = "Ekinci";
            musteri3.TC = 1234563;

            MusteriManager manager = new MusteriManager();
            manager.Ekle(musteri1);
            manager.Ekle(musteri2);
            manager.Ekle(musteri3);
            Console.WriteLine("--------Müşteri Listesi-------");
            manager.Listele(musteri1, musteri2, musteri3);
            manager.Sil(musteri2);
            manager.Güncelle(musteri3);

            Console.ReadLine();

        }
    }
}
