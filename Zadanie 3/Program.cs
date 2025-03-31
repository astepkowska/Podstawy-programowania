using System;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i
            //wypisujący posortowane liczby na ekranie.

            int[] tab = new int[1000]; // ustalam tablice o 1000 elementach typu int
            int i, j; // deklaracja zmiennych i, j typu int
            int n, tmp; // n elementów tablicy, tmp zmienna pomocnicza
            Console.WriteLine("Podaj ilosc elementów tablicy n <=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++) // petla for, ktora wczytuje liczby do tablicy
            {
                Console.Write("Podaj tab[{0}]=", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++) // petla for, ktora sortuje elementy tablicy
            {
                for (j = i+1; j < n; j++)
                {
                    if (tab[i] > tab[j]) //zmiana kolejnoci elementów tablicy
                    {
                        tmp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = tmp;
                    }
                }
            }
            Console.WriteLine("Elementy tablicy: ");
            for (i = 0; i < n; i++) // petla for, ktora wypisuje elementy tablicy
            {
                Console.WriteLine("{0}", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
