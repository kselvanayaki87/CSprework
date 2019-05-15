using System;

namespace Module1_SelfAssessment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Student information using input from console

            Console.WriteLine("Student information");
            Console.WriteLine("Enter Student Firstname");
            String SFirstname = Console.ReadLine();
            Console.WriteLine("Enter Student Lastname");
            String SLastname = Console.ReadLine();
            Console.WriteLine("Enter Student Birthdate in YYYYMMDD format");
            DateTime Sbirthdate = DateTime.ParseExact(Console.ReadLine(), "yyyyMMdd",
                                System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter Student Address line 1");
            String SAddressline1 = Console.ReadLine();
            Console.WriteLine("Enter Student Address line 2");
            String SAddressline2 = Console.ReadLine();
            Console.WriteLine("Enter Student City");
            String SCity = Console.ReadLine();
            Console.WriteLine("Enter Student State/Province");
            String SState = Console.ReadLine();
            Console.WriteLine("Enter Student zipcode");
            int Szipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Country");
            String SCountry = Console.ReadLine();
            Console.WriteLine("Firstname\tLastname\t\tBirthdate\tAddressline1\tAddressline2\tCity\tState\tzipcode\tCountry");

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", SFirstname, SLastname, Sbirthdate.ToString("yyyy/MM/dd"), SAddressline1, SAddressline2, SCity, SState, Szipcode, SCountry);
            //Console.WriteLine($"{birthdate}");

            //Assigning values to variables and printing
            //Teacher information

            //Declaration of variables
            String TFirstName;
            String TLastName;
            DateTime TBirthdate;
            String TAddressline1;
            String TAddressline2;
            String TCity;
            String TState;
            int Tzipcode;
            String TCountry;

            //Assigning values to variables

            TFirstName = "Tom";
            TLastName = "Sawyer";
            TBirthdate = new DateTime(1970, 06, 01);
            TAddressline1 = "12425 45th ST NE";
            TAddressline2 = "NA";
            TCity = "Bellevue";
            TState = "Washington";
            Tzipcode = 98208;
            TCountry = "USA";

            // Printing of Teacher's information

            Console.WriteLine("First name\tLast name\t\tBirthdate\tAddress line1\tAddress line2\tCity\tState\tzipcode\tCountry");

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", TFirstName, TLastName, TBirthdate.ToString("yyyy/MM/dd"), TAddressline1, TAddressline2, TCity, TState, Tzipcode, TCountry);

            //Degree information
            String Degreename;
            float creditsrequired;

            //Assigning values to variables and printing to console

            Degreename = "Software Engineering";
            creditsrequired = 7.5f;

            Console.WriteLine("Degree name\tCredits Required");
            Console.WriteLine("{0}{1}", Degreename, creditsrequired);

            //Course information

            //Assigning values to variables and printing to console

            String Coursename;
            float credits;
            int durationinweeks;
            String teacher;


            Coursename = "Software Development";
            credits = 6.5f;
            durationinweeks = 14;
            teacher = "Tom Sawyer";

            Console.WriteLine("Course Name\tCredits\tDuration in weeks\tTeacher");
            Console.WriteLine("{0}{1}{2}{3}", Coursename, credits, durationinweeks, teacher);

        }
    }
}
