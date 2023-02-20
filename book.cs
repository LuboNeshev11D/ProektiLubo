using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            library spisak=new library();
            foreach (Book item in spisak)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
  