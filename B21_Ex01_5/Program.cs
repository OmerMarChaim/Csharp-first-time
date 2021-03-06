using System;

namespace B21_Ex01_5
{
    public static class Program
    {
        public static void Main()
        {
            int expectedInputLength = 6;
            string userInputStr = getValidInput(expectedInputLength);
            int userInputNum = int.Parse(userInputStr);

            analyzeNumber(userInputNum, userInputStr);
        }

        private static string getValidInput(int i_ExpectedInputLength)
        {
            Console.WriteLine("Please enter a valid input: Positive number with 6 digits");
            string userInput = Console.ReadLine();
            while(!(isPositiveNumber(userInput) && userInput.Length == i_ExpectedInputLength))
            {
                Console.WriteLine("Your input is invalid. Pleas try again.");
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        private static bool isPositiveNumber(string i_String)
        {
            bool isPositiveNumberFlag = int.TryParse(i_String, out int numberParseResult) && numberParseResult > 0;

            return isPositiveNumberFlag;
        }

        private static void analyzeNumber(int i_InputInt, string i_InputStr)
        {
            int userInputInt = i_InputInt;
            int largestDigit = i_InputInt % 10; // 1 - check the largest digit
            int smallestDigit = i_InputInt % 10; // 2 - check the smallest digit
            int numberOfLettersDivideByThree =
                getNumberOfDigitsDividedByThree(i_InputStr); // 3 - how many letters are divide by 3
            int numberOfDigitsBiggerThenUnitsDigit = 0;
            int unitDigit = userInputInt % 10;

            while(userInputInt > 0)
            {
                largestDigit = Math.Max(userInputInt % 10, largestDigit);
                smallestDigit = Math.Min(userInputInt % 10, smallestDigit);
                if(userInputInt % 10 > unitDigit)
                {
                    numberOfDigitsBiggerThenUnitsDigit++;
                }

                userInputInt /= 10;
            }

            Console.WriteLine(
                string.Format(
                    @"The largest digit is {0}
The smallest digit is {1}
The number of digits that multiplication of three is {2}
The number of digits that are bigger than the units digit is {3}
",
                    largestDigit,
                    smallestDigit,
                    numberOfLettersDivideByThree,
                    numberOfDigitsBiggerThenUnitsDigit));

            // int largestDigit = getLargestDigit(i_InputInt);

            // int smallestDigit = getSmallestDigit(i_InputInt);

            //print the results
            // Console.WriteLine(string.Format("The largest digit is {0}", largestDigit)) // 
            // Console.WriteLine(string.Format("The smallest digit is {0}", smallestDigit));
            // Console.WriteLine(
            //     string.Format(
            //         "The number of digits that multiplication of three is {0}",
            //         numberOfLettersDivideByThree));
            // Console.WriteLine(
            //     string.Format(
            //         "The number of digits that are bigger than the units digit is{0}",
            //         numberOfDigitsBiggerThenUnitsDigit));
        }

        private static int getNumberOfDigitsDividedByThree(string i_Number)
        {
            int numberOfDigitsCounter = 0;
            int numberOfDigits = i_Number.Length;
            for(int i = 0; i < numberOfDigits; i++)
            {
                int currentDigit = int.Parse(i_Number[i].ToString());
                if(currentDigit % 3 == 0)
                {
                    numberOfDigitsCounter++;
                }
            }

            return numberOfDigitsCounter;
        }
    }
}