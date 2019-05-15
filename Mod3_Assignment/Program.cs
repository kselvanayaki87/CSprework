using System;

namespace Mod3_Assignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GetStudentInformation();

            try
            {
                datevalidation();
            }
            catch (NotImplementedException)

            {
                Console.WriteLine("Student BirthDate validation Not implemented yet");

            }
            GetteacherInformation();
            getcourseinfo();
            getdegreeinfo();

        }

        //Student information
        static void GetStudentInformation()
            {
                Console.WriteLine("Enter the student's first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter the student's last name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter the student's DOB ");
                DateTime birthdate = DateTime.ParseExact(Console.ReadLine(), "yyyyMMdd",
                                    System.Globalization.CultureInfo.InvariantCulture);
                printStudentInformation(firstName, lastName, birthdate);
            }

            static void printStudentInformation(string fname, String lname, DateTime dob)
            {
                Console.WriteLine($"student's first name: {fname}");
                Console.WriteLine($"student's first name: {lname}");
                //Console.WriteLine($"student's DOB : {dob}");
                Console.WriteLine("Student DOB is {0}", dob.ToString("yyyy/MM/dd"));
                Console.WriteLine("{0} {1} was born on: {2}", fname, lname, dob.ToString("yyyy/mm/dd"));


            }
            static void datevalidation()
            {
                // Not developed yet.
                throw new NotImplementedException();
            }
            //Teacher information
            static void GetteacherInformation()
            {
                Console.WriteLine("Enter the Teacher's first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter the Teacher's last name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter the Teacher's DOB ");
                DateTime birthdate = DateTime.ParseExact(Console.ReadLine(), "yyyyMMdd",
                                    System.Globalization.CultureInfo.InvariantCulture);
                Console.WriteLine("Enter Teacher's zipcode");
                int zipcode = Convert.ToInt32(Console.ReadLine());
                printteacherInformation(firstName, lastName, birthdate, zipcode);



            }
            static void printteacherInformation(string fname, String lname, DateTime dob, int zip)
            {
                Console.WriteLine($"Teacher's first name: {fname}");
                Console.WriteLine($"Teacher's last name: {lname}");
                //Console.WriteLine($"Teacher's DOB : {dob}");
                Console.WriteLine("Teacher's DOB is {0}", dob.ToString("yyyy/MM/dd"));
                Console.WriteLine($"Tecaher's zipcode is: {zip}");

            }
            static void getcourseinfo()
            {
                Console.WriteLine("Enter the course name: ");
                string coursename = Console.ReadLine();
                Console.WriteLine("Enter the course duration: ");
                int courseduration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the credits");
                float coursecredits =float.Parse(Console.ReadLine());
                printcourseinfo(coursename, courseduration, coursecredits);
            }
            static void printcourseinfo(string coursename, int courseduration, float coursecredits)
            {
                Console.WriteLine($"Course name is: {coursename}");
                Console.WriteLine($"Course duration is : {courseduration}");
                Console.WriteLine("Course credits is : {0}", coursecredits);
                //Console.WriteLine($"Course credits is : {coursecredits}");
        }

            static void getdegreeinfo()
            {
                Console.WriteLine("Enter the Degree name: ");
                string degreename = Console.ReadLine();
                Console.WriteLine("Enter the degree duration: ");
                int degreeduration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the credits");
                float degreecredits = float.Parse(Console.ReadLine());
                printdegreeinfo(degreename, degreeduration, degreecredits);
            }
            static void printdegreeinfo(string degreename, int degreeduration, float degreecredits)
            {
                Console.WriteLine($"Degree name is: {degreename}");
                Console.WriteLine($"Degree duration is : {degreeduration}");
                Console.WriteLine("Degree credits is : {0}", degreecredits);
            }
    }
}
