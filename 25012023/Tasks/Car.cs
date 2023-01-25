using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Car
    {
        public Car(int year)
        {
            Year = year;
        }

        public Car(int year,string brand)
        {
            this.Year = year;
            this.Brand = brand;
        }

        public int Year;
        public string Brand;
        public string Model;
    }
}
