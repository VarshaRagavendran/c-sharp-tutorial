using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car("Nissan", "370Z", 2018, "white");
            Console.WriteLine("{0} {1} {2} {3}", myCar1.Make, myCar1.Model, myCar1.Year, myCar1.Color);
        }
    }

    class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }
    }
}
