using System;

namespace Mod3_Lab1
{
    class MainClass
    {
        //no return value
        /*public static void Main(string[] args)
        {
            Sum(1, 5);
        }
        static void Sum(int first, int second)
        {
            int sum = first + second;
            Console.WriteLine($"The sum of {first} and {second} is {sum}");
        }*/
        //method returns a value
        /*public static void Main(string[] args)
        {
            int result = Sum(1, 5);
            Console.WriteLine($"The sum of 1 and 5 is {result} ");
        }
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;        
        }*/
        //method overloading
        public static void Main(string[] args)
        {
            int result = Sum(1, 5);
            Console.WriteLine($"Calling Sum() with two arguments, result is: {result}");

            int result1 = Sum(1, 09, 90);
            Console.WriteLine($"Calling Sum() with three arguments, result is: {result1}");

            Double doubleresult = Sum(10.9, 345.8);
            Console.WriteLine($"Calling Sum() with double arguments, result is: {doubleresult}");

        }
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }
        static Double Sum(double first, double second)
        {
            double sum = first + second;
            return sum;
        }
    }
}
