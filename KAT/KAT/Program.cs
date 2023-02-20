using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAT
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<DasAuto> list1 = new List<DasAuto>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] danni = Console.ReadLine().Split();
                DasAuto auto = new DasAuto(111111,"Audi","Anton","Stoyanov");
               
            }
        }
      
    }
}
