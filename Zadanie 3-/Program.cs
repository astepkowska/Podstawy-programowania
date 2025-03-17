using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to
            // liczba parzysta, czy też nieparzysta.
            double a, b, c;
            Console.Write("Podaj liczbę nr 1: ");
                a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 2: ");
                b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 3: ");
                c = Convert.ToDouble(Console.ReadLine());
            if ((a <= b) && (a <= c))
                Console.WriteLine("Najmniejsza liczba to: " + a);
            else if((b <= a) && (b <= c))
                Console.WriteLine("Najmniejsza liczba to: " + b);
            else
                Console.WriteLine("Najmniejsza liczba to: " + c);
            if ((a>=b) && (a>=c))
                Console.WriteLine("Największa liczba to: " + a);
            else if((b >= a) && (b >= c))
                Console.WriteLine("Największa liczba to: " + b);
            else
                Console.WriteLine("Największa liczba to: " + c);
            Console.ReadKey(true);
        }
    }
}
