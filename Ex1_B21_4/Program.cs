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

      //  private static string validInputUser()
      //  {
        //    string validInput;

           // return validInput;
    //    }

        private static void stringAnalise(string i_Input)
        {
            bool isPalindromFlag = isPalindrome(i_Input);
            Console.WriteLine("this is a palindrom{0}",isPalindromFlag);
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

        private static bool isNumber()
        {
            throw new NotImplementedException();
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