using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ConsoleValidation
{
    public static class ConsoleValidator
    {
        /// <summary>
        /// helper method to get a valid integer from the user
        /// </summary>
        /// <param name="minValue">inclusive mimimum value</param>
        /// <param name="maxValue">inclusive maximum value</param>
        /// <param name="maxAttempts">maximum number of attempts</param>
        /// <param name="prompt">user prompt for integer value</param>
        /// <param name="validInput">indicates valid user input</param>
        /// <returns></returns>
        public static int GetIntegerFromUser(int minValue, int maxValue, int maxAttempts, string prompt, out bool validInput)
        {
            validInput = false;
            string userResponse;
            int userInteger = 0;
            int attempts = 1;

            while (!validInput && attempts <= maxAttempts)
            {
                Console.Write(prompt);
                userResponse = Console.ReadLine();

                //
                // input is an Integer
                //
                if (int.TryParse(userResponse, out userInteger))
                {
                    //
                    // input is in range
                    //
                    if (userInteger >= minValue && userInteger <= maxValue)
                    {
                        validInput = true;
                    }
                    //
                    // input is not in range
                    //
                    else
                    {
                        Console.WriteLine($"It appears you did not enter an integer between {minValue} and {maxValue}. Please try again.");
                        Console.WriteLine();
                    }
                }
                //
                // input is not an Integer
                //
                else
                {
                    Console.WriteLine("It appears you did not enter an integer. Please try again.");
                    Console.WriteLine();
                }

                attempts++;
            }

            return userInteger;
        }
    }
}
