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

            //TestYesNoMethod();
        }

        private static void TestYesNoMethod()
        {
            bool maxAttemptsExceeded;
            string userResponse;

            //
            // (number of attempts allowed, text prompt, return number of attempt status)
            //
            userResponse = ConsoleValidator.GetYesNoFromUser(3, "Do you want to be a Wizard?", out maxAttemptsExceeded);

            //
            // echo status to user
            //
            if (!maxAttemptsExceeded)
            {
                Console.WriteLine($"You have entered {userResponse}.");
            }
            else
            {
                Console.WriteLine("You are obviously a mere mortal and will be excommunicated from The Order!");
            }

            Console.ReadKey();
        }

        static void TestIntegerMethod()
        {
            bool maxAttemptsExceeded;
            int userInteger;

            //
            // (minimum value, maximum value, number of attempts allowed, text prompt, return number of attempt status)
            //
            //userInteger = ConsoleValidator.GetIntegerFromUser(1, 10, 3, "cats", out maxAttemptsExceeded);

            //
            // (minimum value, number of attempts allowed, text prompt, return number of attempt status)
            //
            //userInteger = ConsoleValidator.GetIntegerFromUser(1, 3, "cats", out maxAttemptsExceeded);

            //
            // (minimum value, number of attempts allowed, text prompt, return number of attempt status)
            //
            userInteger = ConsoleValidator.GetIntegerFromUser(3, "cats", out maxAttemptsExceeded);

            //
            // echo status to user
            //
            if (!maxAttemptsExceeded)
            {
                Console.WriteLine($"You have entered {userInteger}.");
            }
            else
            {
                Console.WriteLine("You are obviously a mere mortal and will be excommunicated from The Order!");
            }

            Console.ReadKey();
        }
    }
}
