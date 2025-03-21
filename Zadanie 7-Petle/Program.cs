using System;

namespace Zadanie_7_Petle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Spośród liczb od 1 do 100 wypisz na ekranie wszystkie liczby podzielne przez 13. Użyj pętli for

            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 13 == 0) //reszta z dzielenia przez 13=0
                    Console.WriteLine("{0}", i); //wypisz liczby podzielne przez 13
            }
            Console.ReadKey(true);
        }
    }
}
