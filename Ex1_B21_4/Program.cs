using System;

namespace Ex1_B21_4
{
    public static class Program
    {
        public static void Main()
        {
            int expectedInputLength = 10;
            string input = getValidInput(expectedInputLength);
            stringAnalyze(input);
        }

        private static string getValidInput(int i_ExpectedInputLength)
        {
            Console.WriteLine("Please enter a valid input: consist of ten characters of all English letters only OR ALL digits numbers");
            string userInput = Console.ReadLine();
            while(!((isNonNegativeNumber(userInput) || isEnglishWord(userInput)) && userInput.Length == i_ExpectedInputLength))
            {
                Console.WriteLine("Your input is invalid. Please try again.");
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        private static void stringAnalyze(string i_Input)
        {
            bool isMultiplicationOfFourFlag;
            string multiplicationOfFourOutput = "Your input is multiplication of 4";
            bool isPalindromeFlag = isPalindrome(i_Input);
            string palindromeResultOutput = "Your input is Palindrome";
            if(!isPalindromeFlag)
            {
                palindromeResultOutput = "Your input is NOT Palindrome";
            }

            Console.WriteLine(palindromeResultOutput);

            if(isNonNegativeNumber(i_Input))
            {
                isMultiplicationOfFourFlag = isMultiplicationOfFour(i_Input);
                if(!isMultiplicationOfFourFlag)
                {
                    multiplicationOfFourOutput = "Your input is NOT multiplication of 4";
                }

                Console.WriteLine(multiplicationOfFourOutput);
            }
            else
            {
                Console.WriteLine(
                    "The number of capital letters (uppercase) in your input is {0}",
                    numberOfCapitalLetters(i_Input));
            }
        }

        private static int numberOfCapitalLetters(string i_Input)
        {
            int numOfCapital = 0;
            foreach(char t in i_Input)
            {
                if(t >= 'A' && t <= 'Z')
                {
                    numOfCapital++;
                }
            }

            return numOfCapital;
        }

        private static bool isMultiplicationOfFour(string i_Input)
        {
            long numberRepInput = long.Parse(i_Input);

            return numberRepInput % 4 == 0;
        }

        private static bool isNonNegativeNumber(string i_String)
        {
            bool isNonNegativeNumberFlag = long.TryParse(i_String, out long numberParseResult) && numberParseResult >= 0;

            return  isNonNegativeNumberFlag;
        }

        private static bool isEnglishWord(string i_UserInput)
        {
            bool isEnglishWordFlag = true;
            foreach(char t in i_UserInput)
            {
                if(!(char.IsLower(t) || Char.IsUpper(t)))
                {
                    isEnglishWordFlag = false;

                    break;
                }
            }

            return isEnglishWordFlag;
        }

        private static bool isPalindrome(string i_String)
        {
            return isPalindromeReqHelper(i_String, 0, (i_String.Length) - 1, false);
        }

        private static bool isPalindromeReqHelper(
            string i_String,
            int i_LeftEdge,
            int i_RightEdge,
            bool i_PalindromeFlag)
        {
            if(i_LeftEdge > i_RightEdge)
            {
                i_PalindromeFlag = true;
            }

            else if(i_String[i_LeftEdge] != i_String[i_RightEdge])
            {
                i_PalindromeFlag = false;
            }

            else
            {
                i_PalindromeFlag = isPalindromeReqHelper(i_String, i_LeftEdge + 1, i_RightEdge - 1, i_PalindromeFlag);
            }

            return i_PalindromeFlag;
        }
    }
}