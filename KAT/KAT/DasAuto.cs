using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAT
{
    public class DasAuto
    {
        private int rNumber;

        public int RNumber
        {
            get { return rNumber; }
            set
            {
                if (value < 6)
                {
                    Console.WriteLine("greshka v sistemata");
                }
                this.rNumber = value;
            }
        }
        private string marka;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        private string ime;

        public string Ime
        {

            get { return ime; }
            set { ime = value; }
        }
        private string familiq;
        public string Familiq
        {

            get { return familiq; }
            set { familiq = value; }
        }
        private int cena;

        public int Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        public void Print()
        {
            Console.WriteLine($"{this.rNumber}e{this.marka}prinadleji na {this.ime} {this.familiq}");
        }
        public DasAuto(int rNumer, string marka, string ime, string familiq)
        {
            this.rNumber = RNumber;
            this.marka = Marka;
            this.ime = Ime;
            this.familiq = Familiq;
        }
        public DasAuto()
        {
        }


    }
}
