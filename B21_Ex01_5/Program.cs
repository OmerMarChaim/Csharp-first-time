﻿using System;

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

            analyzeNumber(userInputNum);
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
        private static void analyzeNumber(int i_Input)
        {
            int largestDigit = getLargestDigit(i_Input);
            int smallestDigit = getSmallestDigit(i_Input);
            int numberOfLettersDivideByThree = 0;
            int numberOfDigitisThatAreBiggerThenTheUnitsDigit = getBiggerThenUnit(i_Input);
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
                userInput = userInput/ 10;
            }

            return largestDigit;
        }

        private static int getSmallestDigit(int i_Number)
        {
            int userInput = i_Number;
            int smallestDigitnNumber = i_Number % 10;

            while(userInput > 0)
            {
                smallestDigitnNumber = Math.Min(userInput % 10, smallestDigitnNumber);
                userInput /= 10;
            }

            return smallestDigitnNumber;
        }
        
    }
}