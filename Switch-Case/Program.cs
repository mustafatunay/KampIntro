using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            // klavyeden girilen sayıya göre haftanın gününü veren program.

            
            Console.Write("1 ile 7 arasında bir rakam giriniz: ");
            int sayi = Convert.ToInt16(Console.ReadLine());

            switch (sayi)
            {

                case 1: Console.Write("Gün = Pazartesi");
                    break;
                case 2: Console.Write("Gün = Salı");
                    break;
                case 3: Console.Write("Gün = Çarşamba");
                    break;
                case 4: Console.Write("Gün = Perşembe");
                    break;
                case 5: Console.Write("Gün = Cuma");
                    break;
                case 6: Console.Write("Gün = Cumartesi");
                    break;
                case 7: Console.Write("Gün = Pazar");
                    break;
                default:
                    Console.WriteLine("Hatalı Gün Girişi"); 
                    break;             
            }
            Console.ReadLine();




        }
    }
}
