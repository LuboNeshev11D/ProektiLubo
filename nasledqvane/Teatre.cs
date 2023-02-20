using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledqvane
{
    public class Teatre
    {
        protected string imeTeathre;
        protected string city; 
        public Teatre(string imeTeathre, string city)
        {
            this.imeTeathre = imeTeathre;
            this.city = city;
        }
        public void Print()
        {
            Console.WriteLine($"{this.imeTeathre},{this.city}");
        }
    }
}
