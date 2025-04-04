using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5__While
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący od użytkownika liczbę rzeczywistą x. Wczytuj tak długo wartość
            //zmiennej x, aż przyjmie ona wartość dodatnią. Wczytaną dodatnią wartość liczby x wypisz na
            //ekranie.Użyj pętli do -whileWczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z

            double x;

            do

            {
                Console.Write("Podaj x= ");
                x = double.Parse(Console.ReadLine());
            } while (x <= 0);
            Console.WriteLine("Wczytana liczba x wynosi: {0}", x);
            }
            Console.ReadLine(true);
        }
    }
}
