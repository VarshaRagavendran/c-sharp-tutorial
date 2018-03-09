using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car1 = new Car("A1","Oldsmobile", "Cutlas Supreme");
            Car car2 = new Car("A2", "Geo", "Prism");

            Book b1 = new Book("Robert Tabor", "Microsoft .NET XML Web Services", "0-000-00000-0");

            // ArrayLists are dynamically sized
            // allows various objects to be stored
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);

            //Generic List
            List<Car> list = new List<Car>();
            list.Add(car1);
            list.Add(car2);

            //Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VID, car1);
            myDictionary.Add(car2.VID, car2);

            Console.WriteLine(myDictionary["A1"].Make);


            //Object initializaer
            // No need for a Constructor
            //Car car3 = new Car() { Make = "BMV", Model = "750li", VID = "C3" };


            //Collection Initilizer
            /*List<Car> myList = new List<Car>(){
                new Car {Make = "BMV", Model = "750li", VID = "C3"},
                new Car {Make = "BMV", Model = "750li", VID = "C3"}
            };*/

        }
    }

    class Car
    {
        public string VID { get; set;  }
        public string Make { get; set; }
        public string Model { get; set; }

        public Car(string vid, string make, string model)
        {
            this.VID = vid;
            this.Make = make;
            this.Model = model;
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public Book(string author, string title, string isbn){
            this.Author = author;
            this.Title = title;
            this.ISBN = isbn;
        }
    }
}
