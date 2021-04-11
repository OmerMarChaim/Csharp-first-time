using System;

namespace B21_Ex01_5
{
    class Program
    {
        public static void Main()
        {
            string userInput =  getValidInput();
            //check input
           
            analyze(userInput);
        }

        private static string getValidInput()
        {
            throw new NotImplementedException();
        }

        private static void analyze(string i_Input)
        {
            // 1 - check the biggest digit
            // 2 - check the smallest digit
            // 3 - how many letters are divide by 3
            // 4 - the number of digits that bigger then the unit digit
            
        }
    }
}
