using System;

namespace Mod2_Lab4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* //while loop
             int n = 1;
             while (n < 6)
             {
                 Console.WriteLine($"Current value of n is {n}");
                // Console.WriteLine("Current value of n is {0}", n);//
                 n++;
             }*/


            //do while loop
            int x = 10;
            do
            {
                Console.WriteLine("Current value of x is {0}", x);
                x++;
            } while (x >= 10);
        }
    }
}
