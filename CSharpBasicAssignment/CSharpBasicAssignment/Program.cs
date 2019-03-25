using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharpGund
{
    class Program
    {
        private static void RunExerciseOne()
        {
            string FirstName, Lastname;
            FirstName = "John";
            Lastname = "Blom";

            Console.WriteLine("Hello {0} {1}! I'm glad to inform you that you are the test subject of my very first assignment!", FirstName, Lastname);
            Console.ReadLine();
        }

        private static void RunExerciseTwo()
        {
            string Firstname1, Lastname1;

            Console.WriteLine("Hello, please write your first name");
            Firstname1 = Console.ReadLine();

            Console.WriteLine("Please write your last name");
            Lastname1 = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}! Have a nice day!", Firstname1, Lastname1);
        }

        private static void RunExerciseThree()
        {
            Console.WriteLine("Hello, what year were you born in? Answer like yyyy");
            int year1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What was the month you were born in? answer in numbers");
            int month1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What was the date you were born in? answer in numbers");
            int date1 = Convert.ToInt32(Console.ReadLine());

            //Here i convert the answer from a String to an int and later subtract all the answers from todays date to get the age of the person

            int year2 = (2019 - year1);
            int month2 = (03 - month1);
            int date2 = (25 - date1);

                Console.WriteLine("you are {0} years, {1} months and {2} days old", year2, month2, date2);
        }

        private static void RunExerciseFour()
        {
            string timedate = DateTime.Now.ToString("MM/dd/yyyy ss:mm:hh tt");
            //Here i made the current time into a string and converted it to another formato to show later

            Console.WriteLine("The current time and date is {0} in utc and this in another format {1}", DateTime.UtcNow, timedate);
            Console.WriteLine("The date tomorrow is {0} and yesterday it was {1}", DateTime.Today.AddDays(1), DateTime.Today.AddDays(-1));
            Console.ReadLine();
        }

        private static void RunExerciseFive()
        {
            int one = 1;
            int two = 2;
            double three = one + two;
            Console.WriteLine(three);
            Console.ReadLine();

            int odd = 9;
            int even = 4;
            double four = odd / even;
            Console.WriteLine(four);
            Console.ReadLine();
        }



        static void Main(string[] args)
        {

            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue..");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
            }

        }

    }
}
