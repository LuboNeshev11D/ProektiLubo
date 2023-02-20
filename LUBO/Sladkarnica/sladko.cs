using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sladkarnica
{
    public class sladko
    {
        private string stoka;

        public string Stoka
        {
            get { return stoka; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("greshka");
                }
                stoka = value;
            }
        }
        private double cena;

        public double Cena
        {
            get { return cena; }
            set
            {
                if (value > 0)
                {
                    throw new ArgumentException("greshka v sistemata");
                }
                cena = value;
            }
        }
        static private int count = 0;
        static public int Count
        {
            get { return count; }
        }
        public sladko(string stoka, double cena )
        {
            this.stoka = stoka;
            this.cena = cena;
            sladko.count++;
        }
        public void Print()
        {
            Console.WriteLine($"{this.Stoka},e:{this.Cena}: ");
        }
    }
}
