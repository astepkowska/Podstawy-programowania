using System;

namespace Zadanie_4_Petle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
            //posiadający n wierszy i k kolumn. Użyj pętli for

            int n, k, i, j;
            Console.WriteLine("Podaj liczbę naturalną dodatnią n: ");
            n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę naturalną dodatnią k: ");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= k; j++) //liczba kolumn
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}

