using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pechatnica
{
    internal class Pechatnica
    {
        private int godinanaproizvodstvo;
        private string nomernaizdanieto;
        private string zaglavie;
        private int tiraj;
        private double cena;

        public int Godinanaproizvodstvo
        {
            get { return godinanaproizvodstvo; }
            set { godinanaproizvodstvo = value; }
        }
        public string Nomernaizdanieto
        {
            get { return nomernaizdanieto; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("greshka v nomera");
                    this.nomernaizdanieto = value;
                }
            }

        }
        public string Zaglavie
        {
            get { return zaglavie; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("greshka v zaglavieto");
                    this.zaglavie = value;
                }
            }
        }
        public int Tiraj
        {
            get { return tiraj; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("greshka v tiraja");
                    this.tiraj = value;
                }
            }
        }
        public double Cena
        {
            get { return cena; }
            set
            {
                if (value < 0.00)
                {
                    throw new ArgumentException("greshka v cenata");
                    this.cena = value;
                }
            }

        }
        public Pechatnica()
        {
        }
        public Pechatnica(int godinanaproizvodstvo, string nomernaizdanieto, string zaglavie, int tiraj, double cena)
        {
            this.godinanaproizvodstvo = godinanaproizvodstvo;
            this.nomernaizdanieto = nomernaizdanieto;
            this.zaglavie = zaglavie;
            this.tiraj = tiraj;
            this.cena = cena;
        }
        public void PrintZad()
        {
            Console.WriteLine($"{this.godinanaproizvodstvo},e:{this.nomernaizdanieto}" +
                $",e:{this.zaglavie},e:{this.tiraj},e:{this.cena},e:");
        }
    }
    
    
        
    
}
