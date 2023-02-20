using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class KAT
    {
        private string registraciq;
        private string marka;
        private string imeIFamiliq;
        private int cena;

        public string Registraciq
        {
            get { return registraciq; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("it is empty");
                    registraciq = value;
                }
            }
        }
        public string Marka
        {
            get { return marka; }
            set
            {
                throw new FormatException("it is empty");
                marka = value;
            }
        }
        private string ImeIFamiliq
        {
            get { return imeIFamiliq; }
            set
            {
                throw new FormatException("it is empty");
                imeIFamiliq = value; ; }
        }
        private int Cena
        {
            get { return cena; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("prazno e poleto");
                    cena = value;
                }
            }
        }
        public KAT(string registraciq, string marka, string imeIFamiliq, int cena,)
        {
            Registraciq = registraciq;
            Marka = marka;
            ImeIFamiliq = imeIFamiliq;
            Cena = cena;
        }
        public KAT ()
        {

        }
        public override string ToString()
        {
            return $"registraciqta e {this.registraciq}, markata e {this.Marka} imeto i familiqta sa {imeIFamiliq} , cenata e{this.cena}";
        }


    }
}
