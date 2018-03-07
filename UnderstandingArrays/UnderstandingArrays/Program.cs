using System;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: You have to declare an array, by giving it, at the time of declaration, its size
            // integer array
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 5;
            numbers[2] = 6;
            numbers[3] = 7;
            numbers[4] = 9;

            Console.WriteLine("Number of elements inside array: " + numbers.Length);

            //enhanced for loop
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            // string array
            string[] strings = new string[] { "Eddie", "Alex", "Michael", "David" };

            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }

            // char array
            string zig = "You can get what you want out of life," + " if you help enough other people get what they want";

            char[] charArray = zig.ToCharArray();

            foreach (var character in charArray)
            {
                Console.WriteLine(character);
            }

        }
    }
}
