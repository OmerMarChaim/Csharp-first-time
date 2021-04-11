using System;

namespace B21_Ex01_5
{
    class Program
    {
        public static void Main()
        {
            string userInputStr =  getValidInput();
            //check input
            int userInputNum = int.Parse(userInputStr);
            analyze(userInputNum);
        }

        private static string getValidInput()
        {
            Console.WriteLine("Please enter a valid input: number with 6 digits");
            string userInput = Console.ReadLine();
            while(!(Ex1_B21_4.Program.IsNumber(userInput)&& userInput.Length==6))
            {
                Console.WriteLine("Your input is invalid. Pleas try again.");
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        private static void analyze(int i_Input)
        {
            // 1 - check the biggest digit
            // 2 - check the smallest digit
            // 3 - how many letters are divide by 3
            // 4 - the number of digits that bigger then the unit digit
            
        }
    }
}
