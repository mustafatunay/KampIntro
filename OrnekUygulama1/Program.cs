using System;

namespace OrnekUygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Bir manav için satış sitesi kurduğunuzu düşünün.Meyve ve Sebzeler için sınıflar oluşturup, fiyatını, 
            //   ismini barındıran bir küçük kod satırı yazınız. Ve hepsini ekrana yazdırınız.

            Sebzeler sebze1 = new Sebzeler();
            sebze1.sebzeAdi = "Enginar";
            sebze1.sebzeKgFiyati = 5;

            Sebzeler sebze2 = new Sebzeler();
            sebze2.sebzeAdi = "Patlıcan";
            sebze2.sebzeKgFiyati = 4;

            Meyveler meyve1 = new Meyveler();
            meyve1.meyveAdi = "Elma";
            meyve1.meyveKgFiyati = 3;

            Meyveler meyve2 = new Meyveler();
            meyve2.meyveAdi = "Portakal";
            meyve2.meyveKgFiyati = 6;


            Sebzeler[] sebzeCesitleri = new Sebzeler[] {sebze1,sebze2 };
            Meyveler[] meyveCesitleri = new Meyveler[] {meyve1,meyve2 };

            foreach (var sebzeler in sebzeCesitleri)
            {
                Console.WriteLine("Sebze Adı: "+"  "+sebzeler.sebzeAdi);
                Console.WriteLine("Sebze Kg Fiyatı: "+"  "+sebzeler.sebzeKgFiyati);
            }

            foreach (var meyveler in meyveCesitleri)
            {
                Console.WriteLine("Meyve Adı: " + "  " + meyveler.meyveAdi);
                Console.WriteLine("Meyve Kg Fiyatı: " + "  " + meyveler.meyveKgFiyati);
            }

            Console.ReadLine();
            
        }
    }
    class Sebzeler
    {
        public string sebzeAdi { get; set; }
        public int sebzeKgFiyati { get; set; }
       
    }
    class Meyveler
    {
        public string meyveAdi { get; set; }
        public int meyveKgFiyati { get; set; }

    }
}
