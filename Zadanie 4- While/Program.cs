using System;

namespace Zadanie_4__While
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z
            // przedziału [a, b].Użyj pętli while.
            int a, b, i, j;
            Console.WriteLine("Podaj dwie liczby naturalne a i b (0<a<b):");
            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());
            i = 1;

            while ( i <= n)            
            {
               while  (j <= k)
                {
                    j = i;
                    Console.WriteLine("*");
                    j++;
                }
                Console.WriteLine(" ");
                i++;
            }
            Console.ReadLine(true);
        }
    }
}
