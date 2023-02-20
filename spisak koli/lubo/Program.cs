using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("count=");
            int count = int.Parse(Console.ReadLine());
            List<Car> carhub = new List<Car>();
            for (int i = 0; i < count; i++)
            {
                var car = Console.ReadLine().Split();
                Car cars = new Car(car[0], car[1], double.Parse(car[2]));
                carhub.Add(cars);
            }
            foreach (var item in carhub)
            {
                item.Print();
            }
            carhub.OrderBy(l => l.Cena).ToList();
            foreach (l => l.Print()) ;

        }
    }
}
