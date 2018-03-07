using System;

namespace TheIfDecisionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a door: 1, 2, or 3:");
            string userValue = Console.ReadLine();
            string returnMessage = (userValue == "1") ? "car!" : "strand of lint";
            Console.Write("You entered : {0}, therefore you won a {1}.", userValue, returnMessage);
        }
    }
}
