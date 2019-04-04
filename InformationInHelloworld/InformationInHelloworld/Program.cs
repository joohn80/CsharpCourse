using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String Continue = ("Press enter to continue");
                //The string is for a frecuent frase made in the program

                Console.WriteLine("This program will show you the most basic words from a computer");
                    System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("{0}", Continue);
                        //The zero in the writeline defines where the string is going to be put
                        //The string Continue is used after the ending of a sentance
                            Console.ReadLine();
                            //the System threading is making a short pause in the program before it goes over to the next line of code

            Console.WriteLine("Hello world");
                System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("{0}", Continue);
                        Console.ReadLine();
                            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("This is the end of the program, have a great day");
                    System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Press enter to close this console");
                            Console.ReadLine();
        }
    }
}
