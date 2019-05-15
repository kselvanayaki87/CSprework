using System;

namespace Mod1_Lab1
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            String firstName;
            String lastName = "";
            DateTime vbirthdate;
            vbirthdate = new DateTime(2016, 7, 24);
            firstName = "Viyan";
            //lastName = "Yuvaraj";
            lastName = Console.ReadLine();
            //Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine($"Born on {vbirthdate}");
            Console.WriteLine("{0} {1}", firstName, lastName + " " + "Birthday is " + vbirthdate); 

            /* String firstName = "Tom";
             String lastName = "Sawyer";
             Console.WriteLine(firstName + " " + lastName);
             Console.WriteLine("{0} {1}" , firstName, lastName); */
        }

    }
}
