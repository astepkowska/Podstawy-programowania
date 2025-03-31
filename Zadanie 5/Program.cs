using System;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym.

            int[] tab = new int[1000]; // ustalam tablice o 1000 elementach typu int
            int i=0, j; // deklaracja zmiennej i,j typu int
            Console.WriteLine("Podaj liczbę naturalną n: ");
            liczba = Convert.ToInt32(Console.ReadLine());

            for ((liczba/2!=0) || ((liczba/2 == 0) && (liczba%2!= 0)) // petla for, ktora zapisuje reszty z dzielenia przez 2
            {
                tab[i++] = liczba % 2;
                liczba /= 2;
            }
            for (j = i-1; j >>= 0; j--)
            {
                Console.Write(tab[j]) // petla for, ktora wypisuje elementy tablicy (w odwr. kolejnosci)
            }
            Console.ReadKey(true);
        }
    }
}
