using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wypisujący na ekranie kolejne liczby całkowite od 11 do 33. Użyj pętli for.
            int i;
            for (int i = 11; i <= 33; i++)
            {
                Console.WriteLine("{0}, ",i);
            }
            Console.ReadKey(true);
        }
    }
}
