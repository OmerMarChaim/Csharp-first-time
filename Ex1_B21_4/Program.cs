using System;
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

        private static string validInputUser()
        {
            string validInput;

            return validInput;
        }

        private static void stringAnalise(string i_Input)
        {
            bool isPalindromFlag = isPalindrome(i_Input);
            if(isNumber())
            {
                bool isMultipalOfFourFlag = isMultipalOfFour(i_Input);
            }
            else
            {
                Console.WriteLine("The number of capital letters (uppercase) in your input is {0}",numberOfCapitalLetters(i_Input));
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

        private static bool isNumber()
        {
            throw new NotImplementedException();
        }

        private static bool isPalindrome(string i_Input)
        {
            throw new NotImplementedException();
        }
    }
}