using System;

namespace B21_Ex01_5
{
   public static class Program
    {
       

        public static void Main()
        {
            int expectedInputLength = 6;
            string userInputStr =  getValidInput(expectedInputLength);
            //check input
            int userInputNum = int.Parse(userInputStr);

            analyzeNumber(userInputNum,userInputStr);
        }

        private static string getValidInput(int expectedInputLength)
        {
            Console.WriteLine("Please enter a valid input: number with 6 digits");
            string userInput = Console.ReadLine();
            while(!(Ex1_B21_4.Program.IsNumber(userInput) && userInput.Length== expectedInputLength))
            {
                Console.WriteLine("Your input is invalid. Pleas try again.");
                userInput = Console.ReadLine();
            }

            return userInput;
        }
        private static void analyzeNumber(int i_InputInt,string i_InputStr)
        {
            int largestDigit = getLargestDigit(i_InputInt);
            int smallestDigit = getSmallestDigit(i_InputInt);
            int numberOfLettersDivideByThree = 0;
            int numberOfDigitisThatAreBiggerThenTheUnitsDigit = getBiggerThenUnit(i_InputInt);
            char currentDigit;
            Console.WriteLine(string.Format("The largest digit is {0}", largestDigit));
            Console.WriteLine(string.Format("The smallest digit is {0}", smallestDigit));
         //   Console.WriteLine(string.Format("The number of digits that multiplication of 3 is {0}", ));
            Console.WriteLine(string.Format("The number of digits that are bigger than the units digit{0}", numberOfDigitisThatAreBiggerThenTheUnitsDigit));



            // 1 - check the biggest digit

            // 2 - check the smallest digit
            // 3 - how many letters are divide by 3
            // 4 - the number of digits that bigger then the unit digit
        }

        private static int getBiggerThenUnit(int i_Input)
        {
            int unitDigit = i_Input % 10;
            int numOfBiggerThenUnit = 0;
            int userInput = i_Input / 10;
            while(userInput>0)
            {
                int nextDigit = userInput % 10;
                if(nextDigit > unitDigit)
                {
                    numOfBiggerThenUnit++;
                }
                userInput/=10;
            }
            return numOfBiggerThenUnit;
        }

        private static int getLargestDigit(int i_Number)
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

        private static int getSmallestDigit(int i_Number)
        {
            int userInput = i_Number;
            int smallestDigitNumber = i_Number % 10;

            while(userInput > 0)
            {
                smallestDigitNumber = Math.Min(userInput % 10, smallestDigitNumber);
                userInput /= 10;
            }

            return smallestDigitNumber;
        }

        private static int theNumberOfDigitsDividedByThree(string i_Number)
        {
            int numberOfDigitsCounter = 0;
            int numberOfDigits = i_Number.Length;
            for(int i = 0; i < numberOfDigits; i++)
            {
                int.TryParse(i_Number[i].ToString(), out int currentDigit);
                if(currentDigit / 3 == 0)
                {
                    numberOfDigitsCounter++;
                }
            }

            return numberOfDigitsCounter;
        }
    }
}