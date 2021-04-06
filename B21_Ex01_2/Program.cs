using System;
using System.Security.AccessControl;
using System.Text;

namespace B21_Ex01_2
{
    class Program
    {
        public static void Main()
        {
            recursionSandClock( 5,0);
        }

        private static StringBuilder recursionSandClock(int i_Hight, int i_Left ,StringBuilder i_oneLevelAtSandClock)
        {
            if(i_Hight == 1)
            {
                Console.WriteLine("  *  ");

                return new StringBuilder();
            }

            i_oneLevelAtSandClock.Append("*****", i_Left, i_Hight);
            Console.WriteLine(i_oneLevelAtSandClock);

            recursionSandClock(i_Hight-=2,i_Left++,i_oneLevelAtSandClock);
            Console.WriteLine(i_oneLevelAtSandClock);


        }
    }
}
