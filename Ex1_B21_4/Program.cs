using System;
using System.Text;

namespace Ex1_B21_4
{
    public static class Program
    {
        public static void Main()
        {
            String input = getValidInput();
            stringAnalise(input);
        }

        private static string getValidInput()
        {
            Console.WriteLine("Please enter a valid input: consist of English letters only or digits only");
            string userInput = Console.ReadLine();
            while(isNumber(userInput) || isEnglishWord(userInput))
            {
                Console.WriteLine("Your input is invalid. Pleas try again.");
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        private static void stringAnalise(string i_Input)
        {
            bool isPalindromFlag = isPalindrome(i_Input);
            if(isNumber(i_Input))
            {
                bool isMultipalOfFourFlag = isMultipalOfFour(i_Input);
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
            throw new NotImplementedException();
        }

        private static bool isMultipalOfFour(string i_Input)
        {
            throw new NotImplementedException();
        }

        private static bool isNumber(String i_String)
        {
            return int.TryParse(i_String, out int _);
        }

        private static bool isEnglishWord(string i_UserInput)
        {
            bool isEnglishWordFlag = true;
            for(int i = 0; i < i_UserInput.Length; i++)
            {
                if(!(Char.IsLower(i_UserInput[i]) || Char.IsUpper(i_UserInput[i])))
                {
                    isEnglishWordFlag = false;

                    break;
                }
            }

            return isEnglishWordFlag;
        }

        private static bool isPalindrome(string i_Input)
        {
            throw new NotImplementedException();
        }
    }
}