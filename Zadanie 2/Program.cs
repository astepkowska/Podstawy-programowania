using System;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący wczytane
            // liczby w odwrotnej kolejności na ekranie.

            int[] tab = new int[1000]; // ustalam tablice o 1000 elementach typu int
            int i, n; // deklaracja zmiennych i, n typu int
            Console.WriteLine("Podaj ilosc elementów tablicy n <=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++) // petla for, ktora wczytuje liczby do tablicy
            {
                Console.Write("Podaj tab[{0}]=", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elementy tablicy: ");
            for (i = 0; i >= 0; i--) // petla for, ktora wypisuje elementy tablicy
            {
                Console.WriteLine("{0}", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
