using System;
using System.Security.Cryptography;

namespace Zadanie_6_Petle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt równoramienny, który
            //nie jest trójkątem prostokątnym. Użyj pętli for. Przykładowo dla n = 3 narysowany trójkąt
            //powinien wyglądać:
            //  *
            // ***
            //*****
            int n, i, j;
            Console.WriteLine("Podaj liczbę naturalną dodatnią n>1: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) //liczba wierszy
            {
                for (j = 1; j <= n-i; j++) Console.Write(" "); //liczba spacji
                    for (j = 1; j <=2*i-1; j++) Console.Write("*");//liczba kolumn
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }    
}
