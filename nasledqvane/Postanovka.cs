using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledqvane
{
    public class Postanovka:Teatre
    {
        private string namePostanovka;
        public string NamePostanovka
        {
            get { return namePostanovka; }
            set { namePostanovka = value; }

        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Postanovka(string nameTeatre, string city, string namePostanovka, double price) :
            base(nameTeatre, city)
        {
            this.namePostanovka=namePostanovka; 
            this.price = price; 
            this.city = city;   
            
        }
        public void PrintP()
        {
            base.Print();
            Console.WriteLine($"{this.namePostanovka},{this.price:c2}");
        }

    }
}
