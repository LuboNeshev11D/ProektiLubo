using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mnogougulnik
{
    internal class Mnogougulnik
    {
        protected int a, b;
        public Mnogougulnik(int a)
        {
            this.a = a;
        }
        public Mnogougulnik(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public virtual void Print()
        {
            Console.WriteLine("figurata e");
        }

    }
}
