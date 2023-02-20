using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Animal
{
    internal class Animal
    {
        private string type;
        private string name;
        private int age;
        private double food;
        public string Type
        {
        get{return type;}
        set { type = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
         public int Age
        { 
            get { return age; }
            set { age = value; }
        }
        public double Food
        {
            get { return food; }
            set { food = value; }
        }
        public Animal(string type, string name, int age, double food)
        {
            this.type = type;
            this.name = name;
            this.age = age;
            this.food = food;
        }
        public void LeftFood(double LeftFood)
        {
            food -= LeftFood;
        }
        public override string ToString()
        {
            return $"types{this.type},name:{this.name},age:{this.age}, food kg:{this.food}";
        }
    }
}
