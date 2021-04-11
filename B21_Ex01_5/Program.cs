using System;

namespace B21_Ex01_5
{
    class Program
    {
        private static void analyzeString(string i_Input)
        {
            int higestDigit = int.Parse(i_Input[0].ToString());
            int smallestDigit = int.Parse(i_Input[0].ToString());
            int numberOfLettersDivideByThree = 0;
            int lengthOfInput = i_Input.Length;
            char currentDigit;
            Console.WriteLine();
            // 1 - check the biggest digit

            // 2 - check the smallest digit
            // 3 - how many letters are divide by 3
            // 4 - the number of digits that bigger then the unit digit
        }

        public static void Main()
        {
            string userInput = getValidInput();
            //check input

            analyze(userInput);
        }

        private static string getValidInput()
        {
            throw new NotImplementedException();
        }

        private static int largetsDigit(int i_Number)
        {
            int userInput = i_Number;
            int largestDigit = i_Number % 10;

            while(userInput > 0)
            {
                largestDigit = Math.Max(userInput % 10, largestDigit);
                userInput /= 10;
            }

            return largestDigit;
        }

        private static int smallestDigit(int i_Number)
        {
            int userInput = i_Number;
            int largestDigit = i_Number % 10;

            while(userInput > 0)
            {
                largestDigit = Math.Min(userInput % 10, largestDigit);
                userInput /= 10;
            }

            return largestDigit;
        }
        
    }
}