using System;
using System.Text;

namespace B21_Ex01_2
{
    class Program
    {
        public static void Main()
        {
            StringBuilder oneLevelAtSandClock = new StringBuilder();
            oneLevelAtSandClock.Append("*****");
            recursionSandClock(5, new StringBuilder(),oneLevelAtSandClock );
        }

        private static void recursionSandClock(int i_Hight, StringBuilder i_Spaces, StringBuilder i_Stars)
        {
            if(i_Hight == 1)
            {
                Console.WriteLine("  *  ");

                return;
            }
            
            Console.WriteLine("{0}{1}{0}", i_Spaces, i_Stars);
            i_Spaces.Append(" ");
            i_Stars.Remove(0, 2);

            recursionSandClock(i_Hight -= 2, i_Spaces, i_Stars);
            i_Spaces.Remove(0, 1);
            i_Stars.Append("**");
            Console.WriteLine("{0}{1}{0}", i_Spaces, i_Stars);
            
        }
    }
}