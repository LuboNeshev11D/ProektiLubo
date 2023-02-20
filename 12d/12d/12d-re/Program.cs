using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12d
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("vuvedi br na elementite");

            int n=int.Parse(Console.ReadLine());

            List<int> list = new List<int>(n);

            for (int i = 0; i < n ; i++)

            {

                Console.WriteLine("vuvedi element=");

                int height=int .Parse (Console .ReadLine());

                list.Add(height);

            }

            for (int i = 0; i < n-1 ; i++)

            for (int j = 0; j < n-i-1 ; j++)

                    if (list[i] > list[j])

                    {

                        double a = list[i];

                        list[i] = list[j];

                        list[j] = i;

                    }

            Console.WriteLine("sortiran list=");

            Console.WriteLine(String.Join( ' , ' ,list));

            Console.WriteLine("vuvedi 2 indexa=");

            int index1 = int.Parse(Console.ReadLine());

            int index2 = int.Parse(Console.ReadLine());

            Console.WriteLine("element1={0},element2={1}",list[index1],list[index2]);





        }
    }
}
