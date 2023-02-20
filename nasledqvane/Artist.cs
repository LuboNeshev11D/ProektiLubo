using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledqvane
{
    public class Artist:Postanovka
    {
        private string imenaArtista;
        public string ImenaArtista
        {
            get { return imenaArtista; }
            set { imenaArtista = value; }
        }
        public Artist(string nameTeatre, string city, string namePostanovka, double price, string nameArtist):
            base( nameTeatre, city, namePostanovka, price)
        { 
            this.imenaArtista= nameTeatre;  
        
        }
        public void PrintA()
        {
            base.PrintP();
            Console.WriteLine($"{this.imenaArtista},");
        }
    }
}
