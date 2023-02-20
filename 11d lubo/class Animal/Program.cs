namespace class_Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("cat","Pisi",3,1.500);
            Console.WriteLine(animal1.ToString());
            Console.WriteLine("Left Food=");
            double leftfood = double.Parse(Console.ReadLine());
            Console.WriteLine(animal1.ToString());
            animal1.LeftFood(leftfood);

        }
    }
}