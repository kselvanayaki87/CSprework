using System;

namespace Mod2_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer value and press enter");
            int inputvalue = Int32.Parse(Console.ReadLine());
            if(inputvalue % 2 == 0)
            {
                Console.WriteLine("Entered number is even");
            }
            else
            {
                Console.WriteLine("Entered number is not even");
            }
        }
    }
}
