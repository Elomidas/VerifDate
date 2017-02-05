using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = Int32.Parse(Console.ReadLine());
            int b, l, c;
            while(v != 0)
            {
                v--;
                b = (v / 30);
                v -= 30 * b;
                l = v / 6;
                c = v % 6;
                b++;
                l++;
                c++;
                Console.WriteLine("Boite " + b);
                Console.WriteLine("Ligne " + l);
                Console.WriteLine("Colonne " + c);
                Console.WriteLine();
                Console.WriteLine();
                v = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
