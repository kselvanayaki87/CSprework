using System;

namespace Mod2_Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose your coffee size 1 - small ; 2 - medium ; 3 - large ");
            String size = Console.ReadLine();
            int cost = 0;
            switch(size)
            {
                case "1":
                case "small":
                    cost += 25;
                    break;
                case "2":
                case "medium":
                    cost += 50;
                    break;
                case "3":
                case "large":
                    cost += 75;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                    break;
            }
            if (cost !=0 )
            {
                Console.WriteLine("Please insert {0} cents.", cost);
            }
            Console.WriteLine("Thankyou for your business");
        }
    }
}
