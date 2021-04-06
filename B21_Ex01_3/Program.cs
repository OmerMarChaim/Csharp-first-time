using System;
using System.Text;
using B21_Ex01_2;

namespace B21_Ex01_3
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Write the height of the sand clock you wish to see");
            int highOfSandCLockInput = getValidInput();
            if(highOfSandCLockInput % 2 == 0)
            {
                highOfSandCLockInput--;
            }

            StringBuilder firstLine = new StringBuilder();
            for(int i = 0; i < highOfSandCLockInput; i++)
            {
                firstLine.Append("*");
            }

           B21_Ex01_2.Program.RecursionSandClock(highOfSandCLockInput, new StringBuilder(), firstLine);
        }

        private static int getValidInput()
        {
            int result;
            string userInput = Console.ReadLine();
            while(!(int.TryParse(userInput, out result) && result > 0))
            {
                Console.WriteLine("You entered invalid input. Please insert positive number");
                userInput = Console.ReadLine();
            }

            return result;
        }
    }
}