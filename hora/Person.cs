using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hora
{
    internal abstract class Person:Iprint
    {
        protected string name;
        protected string birthday;
        public Person(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
        public abstract double informaciq();
        public virtual void Print()
        {
            Console.WriteLine($"{this.name} {this.birthday}");
        }
       
        


    }
}
