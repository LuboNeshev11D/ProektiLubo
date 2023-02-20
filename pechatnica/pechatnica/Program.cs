using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pechatnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pechatnica> ListMy = new List<Pechatnica>();
            try
            {
                Console.WriteLine("count=");
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    var danni = Console.ReadLine().Split();
                    Pechatnica pechat = new Pechatnica(danni[0], danni[1], int.Parse(danni[2]),
                        double.Parse(danni[3]));
                    List.Add(pechat);

                }
            
            }
        }
    }
}
