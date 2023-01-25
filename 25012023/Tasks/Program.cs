using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student
            {
                FullName = "Hikmet Abbasov",
                GroupNo = "P111",
                Point = 85
            };

            Student student2 = new Student
            {
                FullName = "Nermin Abbasova",
                GroupNo = "P231",
                Point = 34
            };

            Student student3 = new Student();

            student3.FullName = "Tofiq Abdullayev";
            student3.GroupNo = "P138";
            student3.Point = 45;

            Console.WriteLine(student3.IsGradueted());
            Console.WriteLine(student3.GetInfo());


            Car car1 = new Car(2010)
            {
                Brand = "Mercedes",
                Model = "E200",
            };

            Console.WriteLine(car1.Year);

            Car car2 = new Car(2020,"BMW");

            Console.WriteLine(car2.Year);


            string[] arr = new string[5];

            Student[] students = new Student[] { student1, student2, student3,new Student() };


            Product product1 = new Product("Milla Ayran 1L",3.4,10);
            product1.DiscountPercent = 20;

            Product[] products = new Product[3];


            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Mehsul adi:");
                string name = Console.ReadLine();

                double price;
                do
                {
                    Console.WriteLine("Qiymeti:");
                    string priceStr = Console.ReadLine();
                    price = Convert.ToDouble(priceStr);
                } while (price<0);
               

                Console.WriteLine("Endrim faizi:");
                string discountStr = Console.ReadLine();
                double discount = Convert.ToDouble(discountStr);

                Product product = new Product(name, price, discount);

                products[i] = product;
            }


            foreach (var item in products)
            {
                Console.WriteLine(item.Name+" - "+item.Price);
            }




        }
    }
}
