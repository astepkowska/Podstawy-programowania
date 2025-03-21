using System;

namespace Zadanie_8_Petle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj z klawiatury rok_początkowy i rok_końcowy oraz wypisz na ekranie wszystkie lata
            //przestępne od roku_początkowego do roku_końcowego włącznie. Użyj pętli for.
            int a, b, i;
            Console.WriteLine("Podaj rok początkowy: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj rok końcowy: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (i = a; i <= b; i++) //dla lat od początkowego do końcowego
            {
                if (i % 4 == 0 && i % 100!=0 || i % 400==0)//rok przestępny podzielny przez 4
                    Console.WriteLine("{0}", i); //wypisz lata przestępne
            }
            Console.ReadKey(true);
        }
    }
