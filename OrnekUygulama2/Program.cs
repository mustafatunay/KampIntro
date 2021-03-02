using System;
using System.Collections.Generic;

namespace OrnekUygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urunler = new Product();
            urunler.urunKategori = "Elektronik";
            urunler.urunAdi = "Notebook";
            urunler.urunStok = 100;

            Product urunler1 = new Product();
            urunler1.urunKategori = "Spor-Outdoor";
            urunler1.urunAdi = "Dağ Bisikleti";
            urunler1.urunStok = 50;

            Product urunler2 = new Product();
            urunler2.urunKategori = "Kozmetik";
            urunler2.urunAdi = "Şampuan";
            urunler2.urunStok = 250;

            Product[] urunToplam = new Product[] { urunler, urunler1, urunler2 };

            foreach (var urunlerr in urunToplam)
           {
              Console.WriteLine("Ürün Kategorisi: "+urunlerr.urunKategori+" "+"Ürün Adı: "+urunlerr.urunAdi+" "+"Ürün Stoğu: "+urunlerr.urunStok);
            }
            List <Product> urunn = new List <Product>();
            urunn.Add(urunler);
            urunn.Add(urunler1);
            urunn.Add(urunler2);
            for (var i = 0; i < urunn.Count; i++)
            {
                var urun = urunn[i];
                Console.WriteLine("Ürün Kategorisi {0}, Ürün Adı {1}, Ürün Stoğu {2}",urun.urunKategori,urun.urunAdi,urun.urunStok);
            }

            int j = 0;

            while (j<urunn.Count)
            {                     
                Console.WriteLine("Ürün Kategorisi: "+" "+urunn[j].urunKategori+"Ürün Adı: "+" "+urunn[j].urunAdi+"Ürün Stoğu: "+" "+urunn[j].urunStok);
                j++;
            }                               
            Console.ReadLine();
        }
    }
    class Product
    {
        public string urunKategori { get; set; }
        public string urunAdi { get; set; }
        public int urunStok { get; set; }
    }
}
