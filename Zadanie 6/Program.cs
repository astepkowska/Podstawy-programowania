using System;

namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, suma, różnica, iloraz, iloczyn;
            Console.Write("Podaj liczbę a= ");
            a= Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę b= ");
            b= Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            różnica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("Suma wynosi: {0}", suma);
            Console.WriteLine("Różnica wynosi: {0}", różnica); 
            Console.WriteLine("Iloczyn wynosi: {0}", iloczyn);
            Console.WriteLine("Iloraz wynosi: {0}", iloraz);
            Console.ReadKey(true);
        }
    }
}
