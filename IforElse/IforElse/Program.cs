using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IforElse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int Close = 1; Close > 0;)
            {
                Console.Clear();
                Console.WriteLine("Hello, this is a calculator application, if you want to close the application press -1");
                Close = Convert.ToInt32(Console.ReadLine());

                if (Close == -1)
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("Write the first numbers here");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Which of the following do you want to do?");
                Console.WriteLine("1. add, 2. multiply, 3. Divide or 4. subtract?");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Write the Second numbers here");
                int number2 = Convert.ToInt32(Console.ReadLine());

                if (number == 1)
                {
                    int number3 = number1 + number2;
                    Console.WriteLine("It equals to {0}", number3);
                    Console.ReadLine();
                }

                if (number == 2)
                {
                    int number3 = number1 * number2;
                    Console.WriteLine("It equals to {0}", number3);
                    Console.ReadLine();
                }

                if (number == 3)
                {
                    int number3 = number1 / number2;
                    Console.WriteLine("It equals to {0}", number3);
                    Console.ReadLine();
                }

                if (number == 4)
                {
                    int number3 = number1 - number2;
                    Console.WriteLine("It equals to {0}", number3);
                    Console.ReadLine();
                }
            }
            }
        }
    }
