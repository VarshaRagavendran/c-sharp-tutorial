using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Type : int 
            int x = 5;
            int y = x + 9;
            Console.WriteLine(y);

            // Data Type : int with input from console
            string consoleValueOne = Console.ReadLine();
            string consoleValueTwo = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(consoleValueOne) + Convert.ToInt32(consoleValueTwo));

            // Data Type : string 
            Console.WriteLine("What is your Name?");
            Console.Write("What is your First Name? : ");
            string myFirstName = Console.ReadLine();
            Console.Write("What is your Last Name? : ");
            string myLastName = Console.ReadLine();
            Console.WriteLine("Hello " + myFirstName + " " + myLastName + "!");
        }
    }
}
