using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_interator
{
    internal class Pomiar
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private bool dobro;
        public bool Dobro
        {
            get { return dobro; }
            set { dobro = value; }
        }
        public Pomiar(string name,bool dobro)
        { 
            this.dobro = dobro;
            this.name = name;
        }
        public void GetLakomstvo(int brlakomstvo)
        {
            Console.WriteLine($"Pomiar{this.name} said{brlakomstvo}");
        }
    }
}
