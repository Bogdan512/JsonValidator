using System;

namespace jsonValidator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
             bool result = ValidateJson(input);
            if (result == true)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.Read();
        }

        public static bool ValidateJson(string input)
        {
            bool result = true;
            char quotationmark = '"';
            char reverseSolidus = '\\';
            char backspace = '\b';
            char formfeed = '\f';
            char newLine = '\n';
            char carriageReturn = '\r';
            char horizontalTab = '\t';

           for(int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '"':
                        if ( i == 0 || input[i - 1] == reverseSolidus ||  i == input.Length - 1)
                        {
                            result = true;
                            continue;
                        }
                        else
                        {
                            result = false;
                            return result;
                        }
                    case '\\':
                        if (input[0] == '\\')
                        {
                            result = false;
                            return result;
                        }
                        else
                        {
                            if(input[i - 1] == reverseSolidus || input[i + 1] == reverseSolidus
                            || input[i + 1] == quotationmark || input[i + 1] == backspace || input[i + 1] == formfeed
                            || input[i + 1] == newLine || input[i + 1] == carriageReturn || input[i + 1] == horizontalTab)
                            {
                                result = true;
                                continue;
                            }
                        }
                        return result;
                    default:
                        if (input[0] == quotationmark && input[input.Length - 1] == quotationmark)
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                            return result;
                        }
                        continue;
                }
            }
            return result;
        }
    }
}
