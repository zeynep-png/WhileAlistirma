using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Alıştırma
            int sayac = 0;
            while (sayac < 10)
            {
                Console.WriteLine(sayac +1  + " . Kendime inanıyorum, ben bu yazılım işini hallederim!"); // sayacı 0 dan başlattıgım için +1 ekleyerek kaç tane yazdığımın gözükmesini sağladım
                sayac++;
            }
            Console.WriteLine("----------------------------------------------------------");
            //2. Alıştırma
            int i = 1;
            while (i < 20)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("----------------------------------------------------------");
            //3. Alıştırma
            int sayi = 1;
            while (sayi < 20)
            {
                if ( sayi %2 == 0)
                {
                    Console.WriteLine(sayi);
                }
                
                sayi++;
            }
            Console.WriteLine("----------------------------------------------------------");
            //4. Alıştırma
            int sum = 0;
            int num = 51;
            while (num < 150)
            {
                sum += num;
                num++;
            }
            Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + sum);

            Console.WriteLine("----------------------------------------------------------");
            //5. Alıştırma
            int sumEven = 0;
            int sumOdd = 0;
            int number = 1;
            while (number < 120)
            {
                if ((number % 2) == 0)
                {
                    sumOdd += number;
                }
                else
                {
                    sumEven += number;
                }
                number++;
            }
            Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + sumEven + " \n1 ile 120 arasındaki çift sayıların toplamı: " + sumOdd);


            Console.ReadKey();
        }
    }
}
