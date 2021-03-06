﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>(){
                new Car() { VIN="A1", Make = "BMW", Model = "550i", StickerPrice=55000, Year=2013},
                new Car() { VIN="B2", Make = "Toyota", Model = "4Runner", StickerPrice=35000, Year=2013},
                new Car() { VIN="C3", Make = "BMW", Model = "745li", StickerPrice=75000, Year=2012},
                new Car() { VIN="D4", Make = "Ford", Model = "Escape", StickerPrice=25000, Year=2013},
                new Car() { VIN="E5", Make = "BMW", Model = "550i", StickerPrice=57000, Year=2013},

            };

            // LINQ Query Syntax
            /*var bmws = from car in myCars
                         where car.Make == "BMW"
                         && car.Year == 2013
                          select car;*/

            /*var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;*/

            // LINQ Method Syntax
            // compiler determines type of bmws / orderedCars
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2013);
            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1} {2}", car.Model, car.VIN, car.Year);
            }

            var orderedCars = myCars.OrderByDescending(p => p.Year);
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Model, car.VIN, car.Year);
            }

            // Lambda expression
            myCars.ForEach(p => p.StickerPrice -= 3000);

            // Anonymous types -> creating a new data type at run time
            var newCars = from car in myCars
                          where car.Make == "BMW" && car.Year == 2010
                          select new { car.Make, car.Model };
            Console.WriteLine(newCars.GetType());

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
