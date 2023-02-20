using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lubo
{
    internal class Car
    {
        private string carmodel;
        private string registracionennomer;
        private double cena;



        public string CarModel
        {
            get { return this.carmodel; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("pishka");
                }
                this.carmodel = value;
            }
        }
        public string Registracionnomer
        {
            get { return this.registracionennomer; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("hui");
                }
                this.registracionennomer = value;
            }
        }
        public double Cena
        {

            get { return this.cena; }
            set
            {
                if (value < 0) ;
                {
                    throw new ArgumentException("gaza");
                }
                this.cena = value;

            }




        }
        public Car(string carmodel, string registracionennomer, double cena)
        {
            this.carmodel = carmodel;
            this.registracionennomer = registracionennomer;
            this.cena = cena;
        }
        public void Print()
        {
            Console.WriteLine($"Marka={this.CarModel},registraciq={this.registracionennomer},Cena={this.cena}");
        }
    }
}

