using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi dannite");
            int n = int.Parse(Console.ReadLine());

            List<KAT> list1 = new List<KAT>();
            for (int i = 0; i < n; i++)
            {
                string registraciq = Console.ReadLine();
                string marka = Console.ReadLine();
                string ImeIFamiliq = Console.ReadLine();
                string Cena = Console.ReadLine();
            }
            foreach (KAT kat in list1.OrderBy(x => x.Registraciq))
            {
                Console.WriteLine(kat);
            }
        }
    }
}
