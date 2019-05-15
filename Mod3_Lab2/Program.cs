using System;

namespace Mod3_Lab2
{
    class MainClass
    {
        /*public static void Main(string[] args)
        {
            int divres = Divide(10, 0);
        }
    static int  Divide(int first, int second)
        {
            int divres = 0;
            try
            {
                divres = first / second;
            }
            catch (DivideByZeroException)
            //catch (DivideByZeroException ex) whats the purpose of ex?

            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");
            }

            return divres;
        }*/

        //Reading user inputs
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");
            int first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int second = System.Int32.Parse(Console.ReadLine());

            int divres = Divide(first, second);
            Console.WriteLine($"The result of dividing {first} by {second} is {divres}");

        }
        static int Divide(int first, int second)
        {
            int divres = 0;
            try
            {
                divres = first / second;
            }
            catch (DivideByZeroException)

            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");
            }

            return divres;
        }

    }

}
