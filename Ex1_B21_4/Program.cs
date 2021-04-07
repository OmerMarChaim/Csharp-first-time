using System;
using System.Linq;
using System.Text;

namespace Ex1_B21_4
{
    public static class Program
    {
        public static void Main()
        {
           String input = validInputUser();
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

        private static bool isMultipalOfFour(string i_Input)
        {
            int numberRepInput = int.Parse(i_Input);
            return numberRepInput % 4 == 0 ? true : false;
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
            bool palindromeFlag=false;
            return isPalindromeReqHelper(i_Input,0, (i_Input.Length)-1,palindromeFlag);
        }

        private static bool isPalindromeReqHelper(string i_Input, int i_LeftEdge, int i_RightEdge,bool palindromeFlag)
        {
            
            if(i_LeftEdge > i_RightEdge)
            {
                palindromeFlag = true;
                return palindromeFlag;
            }

            if(i_Input[i_LeftEdge] != i_Input[i_RightEdge])
            {
                palindromeFlag = false;
                return palindromeFlag;
            }

            isPalindromeReqHelper(i_Input, i_LeftEdge++, i_RightEdge--,palindromeFlag);
            return palindromeFlag;
        }
    }
}