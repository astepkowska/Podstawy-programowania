using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2__While
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dany jest wzór ciągu a(n)=2n-1. Napisz program wczytujący liczbę całkowitą dodatnią n i
            // wypisujący na ekranie kolejne wyrazy ciągu: a(1), a(2), …, a(n).Użyj pętli while
            int n, an, i;
            Console.WriteLine("Podaj liczbę całkowitą n.");
            Console.Write("a: ");
            n = int.Parse(Console.ReadLine());
           
            i=0;

            while (++i <= n)
            {
                an = 2 * i - 1; // a(n)=2n-1    
                {
                    Console.WriteLine("a({0})={1}", i, an);  //a(n)=2n-1 
                }
                i++;
            }
            Console.ReadLine(true);
        }
    }
}
