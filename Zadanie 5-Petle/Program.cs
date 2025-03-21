using System;

namespace Zadanie_5_Petle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt prostokątny. Użyj
            //pętli for. Przykładowo dla n = 3 narysowany trójkąt powinien wyglądać:
            //*
            //**
            //***
            int n, i, j;
            Console.WriteLine("Podaj liczbę naturalną dodatnią n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) //liczba wierszy
            {
                for (j = 1; j <= i; j++) //liczba kolumn
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
