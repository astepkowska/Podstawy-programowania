using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h, V, Pc, l;
            Console.WriteLine("Podaj promień r=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wysokość h=");
            h = Convert.ToDouble(Console.ReadLine());\
            l = Math.Sqrt(h * h+ r * r); //tworząca stożka
            V = 1 / 3.0 * Math.PI * r * r * h;
            Pc = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("V ={0}", V);
            Console.WriteLine("Pc ={0}", Pc);
            Console.ReadKey(true);
        }
    }
}
