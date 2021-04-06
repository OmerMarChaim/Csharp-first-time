using B21_Ex01_2;
using System;
using System.Text;

namespace B21_Ex01_3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Write the hieght of the sand clock you wish to see");
            String stringNum = getValidinput();
            int highOfSandCLock = int.Parse(stringNum);
            if(highOfSandCLock % 2 == 0)
            {
                highOfSandCLock--;
            }

            StringBuilder firstLine = new StringBuilder();
            for(int i = 0; i < highOfSandCLock; i++)
            {
                firstLine.Append("*");
            }

            B21_Ex01_2.Program.RecursionSandClock(highOfSandCLock, new StringBuilder(), firstLine);
        }

        // private static string getValidinput()
        // {
        //     Console.ReadLine()
        // }
    }
}