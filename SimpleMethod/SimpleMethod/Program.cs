using System;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter where you're from: ");
            string place = Console.ReadLine();
            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(place));
        }

        /**
         * Reverses the characters of the given string
         */
        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        /**
         * Displays the result of reveresed strings
         */
        private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedPlace)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedPlace));
        }
    }
}
