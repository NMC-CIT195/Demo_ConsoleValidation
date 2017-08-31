using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ConsoleValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            TestIntegerMethod();
        }

        static void TestIntegerMethod()
        {
            bool maxAttemptsExceeded;
            int userInteger;

            userInteger = ConsoleValidator.GetIntegerFromUser(1, 10, 2, "Enter an integer.", out maxAttemptsExceeded);

            if (!maxAttemptsExceeded)
            {
                Console.WriteLine($"You have entered {userInteger}.");
            }
            else
            {
                Console.WriteLine("It appears you have exceeded the maximum number of attempts allowed.");
            }

            Console.ReadKey();
        }
    }
}
