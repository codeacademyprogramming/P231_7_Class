using System;

namespace Lesson
{
    class Product
    {
        public string Name;
        public double Price;
        public string Brand;
        public int Count;

        public string GetInfo()
        {
            string info = $"Brand: {this.Brand} - Name: {this.Name} - Price: {Price} - Count:{Count}";
            return info;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            byte age = 45;
            string name = "Hikmet";


            Product pr1 = new Product
            {
                Name = "Iphone 11",
                Price = 850,
                Brand = "Apple",
                Count = 34
            };
            pr1.Price = 950;


            Console.WriteLine(pr1.Name);
            Console.WriteLine(pr1.Brand);
            Console.WriteLine(pr1.Price);

            Console.WriteLine(pr1.GetInfo());

            Product pr2 = new Product();

            pr2.Name = "Iphone 12";
            pr2.Price = 1050;
            pr2.Brand = "Apple";




            Console.WriteLine($"{pr2.Name} - {pr2.Brand} - {pr2.Price}");
            Console.WriteLine($"{pr2.GetInfo()}");

            Human human1 = new Human()
            {
                Age = 40,
                Name = "Hikmet",
                Surname = "Abbasov"
            };


            human1.Age = 45;

            Console.WriteLine(human1.Name+" "+human1.Surname);

            Console.WriteLine(human1.GetFullName());





 
        }
    }
}
