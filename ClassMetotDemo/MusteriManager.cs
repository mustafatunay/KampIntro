using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi" + " " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.MusteriYas);
            Console.WriteLine("------------------------------");
        
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteriler" + " " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.MusteriYas);
                Console.WriteLine("------------------------------");
               // Console.WriteLine(musteriler.Length);
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi" + " " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.MusteriYas);
            Console.WriteLine("------------------------------");

        }


    }
}

