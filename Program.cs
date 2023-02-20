using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputPeople = Console.ReadLine().Split().ToArray();
            List<person> people = new List<person>();
            for (int i = 0; i < inputPeople.Length; i++)
            {
                string[] person = inputPeople[i].Split('=').ToArray();
                Products.Add(new Products(products[0], double.Parse(product[1]));
            }
            string[] command=Console.ReadLine().Split().ToArray();
            while (command[0] != "END")
            {
                string nameOfPerson = command[0];
                string nameOfProduct = command[1];
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Name==nameOfPerson)
                    {
                        people[i].Buy(nameOfProduct, products);
                    }
                    command = Console.ReadLine().Split().ToArray();
                }
                foreach(var)

            }
        }
        

    }
}
