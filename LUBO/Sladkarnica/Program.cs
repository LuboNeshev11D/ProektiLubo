using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sladkarnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sladko izdelie1 = new sladko("Torta",5.50);
            sladko izdelie2 = new sladko("ako", 0.50);
            sladko izdelie3 = new sladko("laino", 1.50);
            sladko izdelie4 = new sladko("aki", 9.50);
            sladko izdelie5 = new sladko("armagan", 10.50);
            sladko izdelie6 = new sladko(Console.ReadLine(), double.Parse(Console.ReadLine()));
            Console.WriteLine($"count={sladko.Count}");
            izdelie1.Print();
        }
    }
}
