using System;

namespace TernaryOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas = Convert.ToInt32(Console.ReadLine());
            //Yaşı; 25'den küçük olanlara A, 25 olanlara B ve 25'den büyük olanlara C değerini döndüren ternary operatörünü oluşturalım.

            string sonuc = yas < 25 ? "A" : (yas == 25 ? "B" : "C");

            Console.WriteLine(sonuc);
           


            


        }
    }
}
