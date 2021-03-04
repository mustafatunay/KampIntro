using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Mustafa";
            musteri1.MusteriSoyadi = "Tünay";
            musteri1.MusteriYas = 26;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Güney";
            musteri2.MusteriSoyadi = "Kahraman";
            musteri2.MusteriYas = 27;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Hüseyin";
            musteri3.MusteriSoyadi = "Bozbey";
            musteri3.MusteriYas = 27;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.MusteriAdi = "Anıl";
            musteri4.MusteriSoyadi = "Emlak";
            musteri4.MusteriYas = 25;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            MusteriManager musteriManagers = new MusteriManager();

            musteriManagers.MusteriListele(musteriler);
            musteriManagers.MusteriEkle(musteri4);
            musteriManagers.MusteriSil(musteri2);

          
          
        }
      
    }
}
