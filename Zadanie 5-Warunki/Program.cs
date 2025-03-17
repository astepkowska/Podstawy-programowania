using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący rok i wypisujący na ekranie informację czy jest to rok przestępny
            //czy też nie
            int rok;
            Console.Write("Podaj rok: ");
            rok = Convert.ToInt32(Console.ReadLine());
            if ((rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0))
                Console.WriteLine("Rok " + rok + " jest rokiem przestępnym");
            else
                Console.WriteLine("Rok " + rok + " nie jest rokiem przestępnym");
            Console.ReadKey(true);
        }
    }
}
