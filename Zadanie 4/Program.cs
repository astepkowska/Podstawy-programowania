using System;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
            //sumę wczytanych liczb.

            int[] tab = new int[1000]; // ustalam tablice o 1000 elementach typu int
            int i; // deklaracja zmiennej i
            int n, suma; // n elementów tablicy, suma elemntow tablicy
            Console.WriteLine("Podaj ilosc elementów tablicy n <=1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++) // petla for, ktora wczytuje liczby do tablicy
            {
                Console.Write("Podaj tab[{0}]=", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            suma = 0;
            for (i = 0; i < n; i++) suma+= tab[i] // petla for, ktora wypisuje wynik sumy elementow tablicy
            {
                Console.WriteLine("Suma elementów tablicy: {0}", suma);
            }
            Console.ReadKey(true);
        }
    }
}
