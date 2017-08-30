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
            bool validInput;
            int userInteger;

            userInteger = ConsoleValidator.GetIntegerFromUser(1, 10, 2, "Enter an integer.", out validInput);

            if (validInput)
            {
                Console.WriteLine(userInteger);
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.ReadKey();
        }
    }
}
