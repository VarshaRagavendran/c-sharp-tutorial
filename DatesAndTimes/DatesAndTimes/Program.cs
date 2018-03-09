using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime myValue = DateTime.Now;

            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString()); // displays just the date 2018-03-07
            Console.WriteLine(myValue.ToShortTimeString()); // displays just the time 9:33 PM
            Console.WriteLine(myValue.ToLongDateString()); // displays Wednesday, March 7, 2018
            Console.WriteLine(myValue.ToLongTimeString()); // displays 9:33:53 PM

            //adding 3 days to current date
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            //adding 3 hours to current time
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());

            //subtract 3 days from current date
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            //subtract 3 hours from current time
            Console.WriteLine(myValue.AddHours(-3).ToLongDateString());

            //Ways of creating new date time object
            DateTime myBirthday = new DateTime(1995, 10, 26);
            Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthdayOptionTwo = DateTime.Parse("10/26/1995");
            Console.WriteLine(myBirthdayOptionTwo);

            // calculating age from current date
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.Days);

        }
    }
}
