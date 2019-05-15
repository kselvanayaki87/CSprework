using System;

namespace Homework
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Validate if entered character is an alphabet and lower/upper case
            Console.WriteLine("Enter a character: ");
            char c = (char)Console.Read();
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("\nThe character is lowercase.");
                }
                else
                {
                    Console.WriteLine("\nThe character is uppercase.");
                }
            }
            else
            {
                Console.WriteLine("\nThe character isn't an alphabetic character.");
            }




        }
    }
}
