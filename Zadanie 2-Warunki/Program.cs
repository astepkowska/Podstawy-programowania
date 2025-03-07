using System;

namespace Zadanie_2_Warunki
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę całkowitą ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Liczba {0} jest dodatnia.", a);
            else if (a < 0)
                Console.WriteLine("Liczba {0} jest ujemna.", a);
            else
                Console.WriteLine("Liczba {0} jest równa 0.", a);
            Console.ReadKey(true);

        }
    }
}
