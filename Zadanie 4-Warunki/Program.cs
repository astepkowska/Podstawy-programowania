using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
            //największej z tych liczb.
            Double a, b, c, d, e, min, max;
            Console.Write("Podaj liczbę nr 1: ");
                a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 2: ");
                b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 3: ");
                c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 4: ");
                d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 5: ");
                e = Convert.ToDouble(Console.ReadLine());
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
                Console.WriteLine("Najmniejsza liczba to: " + min);
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Największa liczba to: " + max);
            Console.ReadKey(true);
        }
    }
}
