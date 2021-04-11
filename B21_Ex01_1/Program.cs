using System;

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
            String[] userInputs = new String[i_NumberOfInputs];
            int[] decimalValues = new int[i_NumberOfInputs];
            String startMsg = String.Format(
                "Please insert {0} positive numbers with {1} digits in valid binary format",
                i_NumberOfInputs,
                i_NumberOfBits);

            Console.WriteLine(startMsg);
            for (int i = 0; i < i_NumberOfInputs; i++)
            {
                userInputs[i] = getValidInputs(i_NumberOfBits);
                decimalValues[i] = binaryToDecimal(userInputs[i]);
            }

            Console.WriteLine("The decimal values of the numbers are:");
            foreach (int number in decimalValues)
            {
                Console.WriteLine(number);
            }

            zerosAndOneAverage(userInputs);
            powerOfTwo(userInputs);
            numberOfStrictlyIncreasingNumbers(decimalValues);
            maxAndMinNumbers(decimalValues);
        }

        private static int binaryToDecimal(String i_BinaryNumber)
        {
            int decimalNumber = 0;
            int length = i_BinaryNumber.Length;

            for (int i = 0; i < length; i++)
            {
                int currentDigit = i_BinaryNumber[i] - '0';
                decimalNumber += currentDigit * (int)Math.Pow(2, length - i - 1);
            }

            return decimalNumber;
        }

        private static String getValidInputs(int i_NumberOfBits)
        {
            String userInput = Console.ReadLine();

            while (userInput != null && !(userInput != "" && isBinary(userInput) && (i_NumberOfBits == userInput.Length)
                                         && IsZero(userInput)))
            {
                Console.WriteLine(
                    "Your number is not a valid binary number. Please insert binary number with {0} bits",
                    i_NumberOfBits);
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        private static bool isBinary(String i_BinaryNumber)
        {
            bool isBinaryFlag = true;
            foreach (char c in i_BinaryNumber)
            {
                if (!(c == '0' || c == '1'))
                {
                    isBinaryFlag = false;
                }
            }

            return isBinaryFlag;
        }

        public static bool IsZero(String i_BinaryNumber)
        {
            bool isZeroFlag = i_BinaryNumber.IndexOf('1') != -1;

            return isZeroFlag;
        }

        private static void numberOfStrictlyIncreasingNumbers(int[] i_DecimalValues)
        {
            int sumOfStrictlyIncreasingNumbers = 0;

            foreach (int t in i_DecimalValues)
            {
                if (isStrictlyIncreasingSeries(t))
                {
                    sumOfStrictlyIncreasingNumbers++;
                }
            }

            Console.WriteLine(
                String.Format(
                "The number of numbers that is strictly monotonically increasing is {0}",
                sumOfStrictlyIncreasingNumbers));
        }

        private static bool isStrictlyIncreasingSeries(int i_NumToCheck)
        {
            int previousDigit = i_NumToCheck % 10;
            i_NumToCheck /= 10;
            while (i_NumToCheck > 0)
            {
                int currentDigit = i_NumToCheck % 10;
                if (currentDigit >= previousDigit)
                {
                    return false;
                }

                previousDigit = currentDigit;
                i_NumToCheck /= 10;
            }

            return true;
        }

        private static void zerosAndOneAverage(String[] i_BinaryValues)
        {
            int numberOfOnes = 0;
            int numberOfDigits = i_BinaryValues[0].Length;
            int lengthOfInput = i_BinaryValues.Length;

            for (int i = 0; i < lengthOfInput; i++)
            {
                numberOfOnes += getNumberOfOnes(i_BinaryValues[i]);
            }

            int numberOfZeros = (numberOfDigits * lengthOfInput) - numberOfOnes;
            float averageOfOnes = numberOfOnes / (float)lengthOfInput;
            float averageOfZeros = numberOfZeros / (float)lengthOfInput;

            Console.WriteLine(string.Format("The average of ones in the input numbers is {0}", averageOfOnes));
            Console.WriteLine(string.Format("The average of zeros in the input numbers is {0}", averageOfZeros));
        }

        private static void powerOfTwo(String[] i_BinaryValues)
        {
            int numberOfPowerOfTwo = 0;

            for (int i = 0; i < i_BinaryValues.Length; i++)
            {
                if (getNumberOfOnes(i_BinaryValues[i]) == 1)
                {
                    numberOfPowerOfTwo++;
                }
            }

            Console.WriteLine(string.Format("The number of numbers that is power of two is {0}", numberOfPowerOfTwo));
        }

        private static int getNumberOfOnes(String i_BinaryValue)
        {
            int onesCounter = 0;

            for (int i = 0; i < i_BinaryValue.Length; i++)
            {
                if (i_BinaryValue[i] == '1')
                {
                    onesCounter++;
                }
            }

            return onesCounter;
        }

        private static void maxAndMinNumbers(int[] i_DecimalValues)
        {
            int maxValue = i_DecimalValues[0];
            int minValue = i_DecimalValues[0];

            foreach (int numInDecimalValues in i_DecimalValues)
            {
                if (numInDecimalValues > maxValue)
                {
                    maxValue = numInDecimalValues;
                }
                else if (numInDecimalValues < minValue)
                {
                    minValue = numInDecimalValues;
                }
            }

            Console.WriteLine(string.Format("The maximum number is {0}", maxValue));
            Console.WriteLine(string.Format("The minimum number is {0}", minValue));
        }
    }
}