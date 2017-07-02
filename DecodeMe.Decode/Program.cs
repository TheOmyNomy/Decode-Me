using System;

namespace DecodeMe.Decode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ascii.Decode";

            Console.Write("Input: ");
            string[] input = Console.ReadLine().Split();

            string segment = string.Empty, result = string.Empty;

            foreach (string ascii in input)
            {
                char character = (char)int.Parse(ascii);

                if (character == ' ')
                {
                    result += reverse(segment) + ' ';
                    segment = string.Empty;
                }
                else segment += character;
            }

            result += reverse(segment).TrimEnd();
            Console.WriteLine("Result: " + result);
        }

        private static string reverse(string line)
        {
            char[] array = line.ToCharArray();
            Array.Reverse(array);

            return new string(array);
        }
    }
}
