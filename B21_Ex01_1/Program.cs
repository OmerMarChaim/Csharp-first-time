using System;
using System.Text;

namespace B21_Ex01_1
{
    public static class Program
    {
        public static void Main()
        {
            int numberOfInputs = 3;
            int numberOfDigits = 7;
            binarySeries(numberOfInputs, numberOfDigits);
        }

        private static void binarySeries(int i_NumberOfInputs, int i_NumberOfBits)
        {
            int totalAmountOfZeros = 0;
            int totalAmountOfOnes = 0;
            int totalAmountOfPowerOfTwo = 0;
            int totalAmountOfIncreasingNumbers = 0;
            int maxValue = 0;
            int minValue = (int)(Math.Pow(2, i_NumberOfBits) - 1); // The Max value for this amount of bits
            int decimalValueInput;
            StringBuilder allDecimalValues = new StringBuilder();
            string userInput;
            string startMsg = String.Format(
                "Please insert {0} positive numbers with {1} digits in valid binary base",
                i_NumberOfInputs,
                i_NumberOfBits);

            Console.WriteLine(startMsg);

            for(int i = 0; i < i_NumberOfInputs; i++)
            {
                userInput = getValidInput(i_NumberOfBits);
                decimalValueInput = binaryToDecimal(userInput);
                allDecimalValues.Append(string.Format("{0}{1}", decimalValueInput, "  "));
                totalAmountOfOnes += getNumberOfOnes(userInput);
                totalAmountOfZeros += (i_NumberOfBits - getNumberOfOnes(userInput));
                if(isStrictlyIncreasingSeries(decimalValueInput))
                {
                    totalAmountOfIncreasingNumbers++;
                }

                if(isPowerOfTwo(userInput))
                {
                    totalAmountOfPowerOfTwo++;
                }

                maxValue = Math.Max(maxValue, decimalValueInput);
                minValue = Math.Min(minValue, decimalValueInput);
            }

            float averageAmountOfZeros = totalAmountOfZeros / (float)i_NumberOfInputs;
            float averageAmountOfOnes = totalAmountOfOnes / (float)i_NumberOfInputs;

            Console.WriteLine(
                string.Format(
                    @"The decimal values of the numbers are {0}
The average amount of ones is {1}
The average amount of zeros is {2}
The number of numbers that is power of two is {3}
The number of numbers that is strictly monotonically increasing is {4}
The maximum value is {5}
The minimum value is {6}",
                    allDecimalValues,
                    averageAmountOfOnes,
                    averageAmountOfZeros,
                    totalAmountOfPowerOfTwo,
                    totalAmountOfIncreasingNumbers,
                    maxValue,
                    minValue));
        }

        private static int binaryToDecimal(String i_BinaryNumber)
        {
            int decimalNumber = 0;
            int length = i_BinaryNumber.Length;

            for(int i = 0; i < length; i++)
            {
                int currentDigit = i_BinaryNumber[i] - '0';
                decimalNumber += currentDigit * (int)Math.Pow(2, length - i - 1);
            }

            return decimalNumber;
        }

        private static string getValidInput(int i_NumberOfBits)
        {
            String userInput = Console.ReadLine();

            while(userInput != null && !(userInput != "" && isBinary(userInput) && (i_NumberOfBits == userInput.Length)
                                         && IsZero(userInput)))
            {
                Console.WriteLine(
                    string.Format(
                        "Your number is not a valid binary number. Please insert binary number with {0} bits",
                        i_NumberOfBits));
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        private static bool isBinary(String i_BinaryNumber)
        {
            bool isBinaryFlag = true;
            foreach(char c in i_BinaryNumber)
            {
                if(!(c == '0' || c == '1'))
                {
                    isBinaryFlag = false;
                }
            }

            return isBinaryFlag;
        }

        public static bool IsZero(string i_BinaryNumber)
        {
            bool isZeroFlag = i_BinaryNumber.IndexOf('1') != -1;

            return isZeroFlag;
        }

        private static bool isStrictlyIncreasingSeries(int i_NumToCheck)
        {
            int previousDigit = i_NumToCheck % 10;
            i_NumToCheck /= 10;
            while(i_NumToCheck > 0)
            {
                int currentDigit = i_NumToCheck % 10;
                if(currentDigit >= previousDigit)
                {
                    return false;
                }

                previousDigit = currentDigit;
                i_NumToCheck /= 10;
            }

            return true;
        }

        private static bool isPowerOfTwo(String i_BinaryValue)
        {
            bool powerOfTwoFlag = getNumberOfOnes(i_BinaryValue) == 1;

            return powerOfTwoFlag;
        }

        private static int getNumberOfOnes(String i_BinaryValue)
        {
            int onesCounter = 0;

            for(int i = 0; i < i_BinaryValue.Length; i++)
            {
                if(i_BinaryValue[i] == '1')
                {
                    onesCounter++;
                }
            }

            return onesCounter;
        }
    }
}