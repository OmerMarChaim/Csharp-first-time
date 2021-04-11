using System;

namespace Ex1_B21_4
{
    public static class Program
    {
        public static void Main()
        {
            string input = getValidInput();
            stringAnalyze(input);
        }

        private static string getValidInput()
        {
            Console.WriteLine("Please enter a valid input: consist of English letters only or digits only");
            string userInput = Console.ReadLine();
            while(!(IsNumber(userInput) || isEnglishWord(userInput)))
            {
                Console.WriteLine("Your input is invalid. Pleas try again.");
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        private static void stringAnalyze(string i_Input)
        {
            bool isPalindromeFlag = isPalindrome(i_Input);
            Console.Write("Your input is ");
            Console.WriteLine(isPalindromeFlag ? "palindrome" : "NOT palindrome");

            if(IsNumber(i_Input))
            {
                bool isMultiplicationOfFourFlag = isMultiplicationOfFour(i_Input);
                Console.Write("Your input is ");
                Console.WriteLine(isMultiplicationOfFourFlag ? "multiplication of 4" : "NOT multiplication of 4");
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
            int numberRepInput = int.Parse(i_Input);

            return numberRepInput % 4 == 0;
        }

        public static bool IsNumber(string i_String)
        {
            return int.TryParse(i_String, out int trashResult);
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

        private static bool isPalindrome(string i_Input)
        {
            return isPalindromeReqHelper(i_Input, 0, (i_Input.Length) - 1, false);
        }

        private static bool isPalindromeReqHelper(
            string i_Input,
            int i_LeftEdge,
            int i_RightEdge,
            bool i_PalindromeFlag)
        {
            if(i_LeftEdge > i_RightEdge)
            {
                return true;
            }

            if(i_Input[i_LeftEdge] != i_Input[i_RightEdge])
            {
                return false;
            }

            i_PalindromeFlag = isPalindromeReqHelper(i_Input, i_LeftEdge + 1, i_RightEdge - 1, i_PalindromeFlag);

            return i_PalindromeFlag;
        }
    }
}