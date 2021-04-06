using System;
using System.Text;

namespace B21_Ex01_2
{
    public static class Program
    {
        public static void Main()
        {
            StringBuilder highLevelAtSandClock = new StringBuilder();
            highLevelAtSandClock.Append("*****");
            RecursionSandClock(5, new StringBuilder(), highLevelAtSandClock);
        }

        public static void RecursionSandClock(
            int i_HeightLevel,
            StringBuilder i_StringOfSpaces,
            StringBuilder i_StringOfStars)
        {
            if(i_HeightLevel == 1)
            {
                Console.WriteLine("{0}{1}{0}", i_StringOfSpaces, i_StringOfStars);

                return;
            }

            Console.WriteLine("{0}{1}{0}", i_StringOfSpaces, i_StringOfStars);
            i_StringOfSpaces.Append(" ");
            i_StringOfStars.Remove(0, 2);

            RecursionSandClock(i_HeightLevel - 2, i_StringOfSpaces, i_StringOfStars);
            i_StringOfSpaces.Remove(0, 1);
            i_StringOfStars.Append("**");
            Console.WriteLine("{0}{1}{0}", i_StringOfSpaces, i_StringOfStars);
        }
    }
}