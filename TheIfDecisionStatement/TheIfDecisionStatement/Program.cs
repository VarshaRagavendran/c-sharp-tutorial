using System;

namespace TheIfDecisionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a door: 1, 2, or 3:");
            string userValue = Console.ReadLine();
            string returnMessage;

            if (userValue == "1")
            {
                returnMessage = "Door chosen : 1";
            }
            else if (userValue == "2")
            {
                returnMessage = "Door chosen : 2";
            }
            else if (userValue == "3")
            {
                returnMessage = "Door chosen : 3";
            }
            else
            {
                returnMessage = "Invalid Door chosen!";
            }
            Console.WriteLine(returnMessage);
        }
    }
}
