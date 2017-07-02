using System;

namespace DecodeMe.Encode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ascii.Encode";

            Console.Write("Input: ");
            string[] input = Console.ReadLine().Split();

            string result = string.Empty;

            foreach (string word in input)
            {
                string segment = string.Empty;
                for (int i = word.Length - 1; i >= 0; i--) segment += (int)word[i] + " ";

                result += segment.TrimEnd() + " 32 ";
            }

            result = result.Remove(result.Length - 4);
            Console.WriteLine("Result: " + result);
        }
    }
}
