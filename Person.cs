using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_proverka_na_danni
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (name.Length < 3)
                {
                    throw new ArgumentException("greshka");
                }
                this.name = value;
            }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (age <= 0)
                {
                    throw new ArgumentException("hui");
                }
                age = value;
            }
        }
        private double zaplata;

        public double Zaplata
        {
            get { return this.zaplata; }
            set 
            {
                if (value<=460)
                {
                    throw new ArgumentException("zaplatata e po malka ot minimalnata");
                }
                 zaplata = value; 
            }
        }
        public Person(string name, int age, double zaplata)
        {
            this.Name = name;
            this.Age = age;
            this.Zaplata = zaplata;

        }
    }
}
