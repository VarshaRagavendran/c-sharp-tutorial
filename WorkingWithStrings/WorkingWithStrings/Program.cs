using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // To use quotes within string
            string quotes = "My \"so-called\" life";
            Console.WriteLine(quotes);

            // New line special character
            string newLine = "what if I need a \nnew line?";
            Console.WriteLine(newLine);

            // Using backslash within string
            string backslashOptionOne = "Go to your c:\\ drive";
            string backslashOptionTwo = @"Go to your c:\ drive";
            Console.WriteLine(backslashOptionOne);
            Console.WriteLine(backslashOptionTwo);

            // Passing in args
            string arguments = String.Format("{0} = {1}", "first", "second");
            Console.WriteLine(arguments);

            // Formatting to currency format
            string currency = string.Format("{0:C}", 123.45);
            Console.WriteLine(currency);

            // Formatting for a large number
            string largeNumber = string.Format("{0:N}", 123443643635);
            Console.WriteLine(largeNumber);

            // Formatting to a percentage
            string percentage = string.Format("Percentage: {0:P}", .123);
            Console.WriteLine(percentage);

            // Formatting goes right to left -> if there are extra numbers
            string phoneNumber = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);
            Console.WriteLine(phoneNumber);
        }
    }
}
