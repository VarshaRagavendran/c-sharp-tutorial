using System;

namespace TheIfDecisionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a door: 1, 2, or 3:");
            string userValue = Console.ReadLine();

            if (userValue == "1")
            {
                Console.WriteLine("Door chosen : 1");
            }
            else if (userValue == "2")
            {
                Console.WriteLine("Door chosen : 2");
            }
            else if (userValue == "3")
            {
                Console.WriteLine("Door chosen : 3");
            }
            else
            {
                Console.WriteLine("Invalid Door chosen!");
            }
        }
    }
}
