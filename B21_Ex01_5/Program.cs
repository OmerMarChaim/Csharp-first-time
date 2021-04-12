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
            Console.WriteLine("Please enter a valid input: number with 6 digits");
            string userInput = Console.ReadLine();
            while(!(Ex1_B21_4.Program.IsNumber(userInput) && userInput.Length == i_ExpectedInputLength))
            {
                Console.WriteLine("Your input is invalid. Pleas try again.");
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        private static void analyzeNumber(int i_InputInt, string i_InputStr)
        {
            int userInputInt = i_InputInt;
            int largestDigit = i_InputInt % 10; // 1 - check the largest digit
            int smallestDigit = i_InputInt % 10; // 2 - check the smallest digit
            int numberOfLettersDivideByThree = getNumberOfDigitsDividedByThree(i_InputStr); // 3 - how many letters are divide by 3
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

            Console.WriteLine(string.Format(
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

        // private static int getBiggerThenUnit(int i_Input)
        // {
        //     int unitDigit = i_Input % 10;
        //     int numOfBiggerThenUnit = 0;
        //     int userInput = i_Input / 10;
        //     while(userInput > 0)
        //     {
        //         int nextDigit = userInput % 10;
        //         if(nextDigit > unitDigit)
        //         {
        //             numOfBiggerThenUnit++;
        //         }
        //
        //         userInput /= 10;
        //     }
        //
        //     return numOfBiggerThenUnit;
        // }

        // private static int getLargestDigit(int i_Number)
        // {
        //     int userInput = i_Number;
        //     int largestDigit = i_Number % 10;
        //
        //     while(userInput > 0)
        //     {
        //         largestDigit = Math.Max(userInput % 10, largestDigit);
        //         userInput /= 10;
        //     }
        //
        //     return largestDigit;
        // }

        // private static int getSmallestDigit(int i_Number)
        // {
        //     int userInput = i_Number;
        //     int smallestDigit = i_Number % 10;
        //
        //     while(userInput > 0)
        //     {
        //         smallestDigit = Math.Min(userInput % 10, smallestDigit);
        //         userInput /= 10;
        //     }
        //
        //     return smallestDigit;
        // }
    }
}