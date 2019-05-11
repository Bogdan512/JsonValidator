using System;

namespace jsonValidator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ValidateJson(input);
            Console.Read();
        }

        public static bool ValidateJson(string input)
        {
            foreach (char c in input)
            {
                if (input[0] == '"' && input[input.Length - 1] == '"')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
