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

            //
            // (minimum value, maximum value, number of attempts allowed, text prompt, return number of attempt status)
            //
            userInteger = ConsoleValidator.GetIntegerFromUser(1, 10, 3, "cats", out maxAttemptsExceeded);

            //
            // echo status to user
            //
            if (!maxAttemptsExceeded)
            {
                Console.WriteLine($"You have entered {userInteger}.");
            }
            else
            {
                Console.WriteLine("Your are obviously a mere mortal and will be excomunicated from The Order!");
            }

            Console.ReadKey();
        }
    }
}
