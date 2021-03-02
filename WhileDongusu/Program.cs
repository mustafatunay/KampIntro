using System;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrana 10 kez Merhaba İstanbul programını for ve while ile yazdırma


            // for (int i = 0; i <= 10; i++)
            //  {
            //    Console.WriteLine("Merhaba İstanbul");
            // }
            //Console.Read();
            //////////////////////////////////////////////////////////////////////////////
            // int i;
            // i = 1;
            // while (i<=10)
            // {
            //     Console.WriteLine("Merhaba İstanbul");
            //     i++;
            // }
            //Console.Read();
            //////////////////////////////////////////////////////////////////////////////////////////////

            // 1 ile 10 arasındaki sayıları yazdıran program

            // int i = 1;
            //  while (i <=1000)
            //  {
            //      Console.WriteLine(i);
            //      i++;
            //  }
            //   Console.Read();
            /////////////////////////////////////////////////////////////////////////////////

            int sayi;
            Console.WriteLine("Bir Sayı giriniz");
            sayi = Convert.ToInt16(Console.ReadLine());

            while (sayi%2==0)
            {
                Console.WriteLine("Bir Sayı giriniz");
                sayi = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Tek sayı girdiniz");
            Console.Read();


            


        }
    }
}
