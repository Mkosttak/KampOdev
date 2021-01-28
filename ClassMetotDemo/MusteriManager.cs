using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: "+ musteri.Isim +" "+ musteri.SoyIsim);
        }
        public  void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi: " + musteri.Isim + " " + musteri.SoyIsim );
        }
        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi Güncellendi: " + musteri.Isim + " " + musteri.SoyIsim);
        }
        public void Listele(params Musteri[] musteriler)
        {
            foreach (var kisi in musteriler)
            {
                Console.WriteLine(kisi.Isim + " " + kisi.SoyIsim);
            }
        }
      
    }
    


}
