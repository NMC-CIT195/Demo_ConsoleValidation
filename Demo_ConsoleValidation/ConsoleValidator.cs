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
        /// helper method to get a valid integer from the user within a range
        /// </summary>
        /// <param name="minValue">inclusive minimum value</param>
        /// <param name="maxValue">inclusive maximum value</param>
        /// <param name="maxAttempts">maximum number of attempts</param>
        /// <param name="pluralName">plural name of item</param>
        /// <param name="validInput">indicates valid user input</param>
        /// <returns></returns>
        public static int GetIntegerFromUser(int minValue, int maxValue, int maxAttempts, string pluralName, out bool maxAttemptsExceeded)
        {
            bool validInput = false;
            maxAttemptsExceeded = false;
            string userResponse;
            string feedbackMessage = "";
            int userInteger = 0;
            int attempts = 1;

            while (!validInput && !maxAttemptsExceeded)
            {
                //
                // more attempts available
                //
                if (attempts <= maxAttempts)
                {
                    Console.Write($"Enter the number, between {minValue} and {maxValue}, of {pluralName}:");
                    userResponse = Console.ReadLine();
                    Console.WriteLine();

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
                            feedbackMessage = $"The number {userInteger} is not in the specified range.";
                        }
                    }
                    //
                    // input is not an Integer
                    //
                    else
                    {
                        feedbackMessage = $"{userResponse} is not an integer.";
                    }

                    if (!validInput && attempts <= maxAttempts)
                    {
                        Console.WriteLine($"You entered: {userResponse}");
                        Console.WriteLine(feedbackMessage);

                        if (attempts < maxAttempts)
                        {
                            Console.WriteLine($"Please enter an integer between {minValue} and {maxValue}.");
                            Console.WriteLine("Press any key to try again.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("It appears you have exceeded the maximum number of attempts allowed.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                        }

                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                    attempts++;
                }
                else
                {
                    maxAttemptsExceeded = true;
                }
            }

            return userInteger;
        }

        /// <summary>
        /// helper method to get a valid integer from the user with a minimum value
        /// </summary>
        /// <param name="minValue">inclusive minimum value</param>
        /// <param name="maxAttempts">maximum number of attempts</param>
        /// <param name="pluralName">plural name of item</param>
        /// <param name="validInput">indicates valid user input</param>
        /// <returns></returns>
        public static int GetIntegerFromUser(int minValue, int maxAttempts, string pluralName, out bool maxAttemptsExceeded)
        {
            bool validInput = false;
            maxAttemptsExceeded = false;
            string userResponse;
            string feedbackMessage = "";
            int userInteger = 0;
            int attempts = 1;

            while (!validInput && !maxAttemptsExceeded)
            {
                //
                // more attempts available
                //
                if (attempts <= maxAttempts)
                {
                    Console.Write($"Enter the number of {pluralName} (Must be at least {minValue}.):");

                    userResponse = Console.ReadLine();
                    Console.WriteLine();

                    //
                    // input is an Integer
                    //
                    if (int.TryParse(userResponse, out userInteger))
                    {
                        //
                        // input is in range
                        //
                        if (userInteger >= minValue)
                        {
                            validInput = true;
                        }
                        //
                        // input is not in range
                        //
                        else
                        {
                            feedbackMessage = $"The number {userInteger} is not at least {minValue}.";
                        }
                    }
                    //
                    // input is not an Integer
                    //
                    else
                    {
                        feedbackMessage = $"{userResponse} is not an integer.";
                    }

                    if (!validInput && attempts <= maxAttempts)
                    {
                        Console.WriteLine($"You entered: {userResponse}");
                        Console.WriteLine(feedbackMessage);

                        if (attempts < maxAttempts)
                        {
                            Console.WriteLine($"Please enter an integer greater than {minValue}.");
                            Console.WriteLine("Press any key to try again.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("It appears you have exceeded the maximum number of attempts allowed.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                        }

                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                    attempts++;
                }
                else
                {
                    maxAttemptsExceeded = true;
                }
            }

            return userInteger;
        }

        /// <summary>
        /// helper method to get a valid positive integer from the user
        /// </summary>
        /// <param name="maxAttempts">maximum number of attempts</param>
        /// <param name="pluralName">plural name of item</param>
        /// <param name="validInput">indicates valid user input</param>
        /// <returns></returns>
        public static int GetIntegerFromUser(int maxAttempts, string pluralName, out bool maxAttemptsExceeded)
        {
            bool validInput = false;
            maxAttemptsExceeded = false;
            string userResponse;
            string feedbackMessage = "";
            int userInteger = 0;
            int attempts = 1;

            while (!validInput && !maxAttemptsExceeded)
            {
                //
                // more attempts available
                //
                if (attempts <= maxAttempts)
                {
                    Console.Write($"Enter the number of {pluralName}:");

                    userResponse = Console.ReadLine();
                    Console.WriteLine();

                    //
                    // input is an Integer
                    //
                    if (int.TryParse(userResponse, out userInteger))
                    {
                        //
                        // input is in range
                        //
                        if (userInteger > 0)
                        {
                            validInput = true;
                        }
                        //
                        // input is not in range
                        //
                        else
                        {
                            feedbackMessage = $"The number {userInteger} is not a positive integer.";
                        }
                    }
                    //
                    // input is not an Integer
                    //
                    else
                    {
                        feedbackMessage = $"{userResponse} is not an integer.";
                    }

                    if (!validInput && attempts <= maxAttempts)
                    {
                        Console.WriteLine($"You entered: {userResponse}");
                        Console.WriteLine(feedbackMessage);

                        if (attempts < maxAttempts)
                        {
                            Console.WriteLine($"Please enter a positive integer.");
                            Console.WriteLine("Press any key to try again.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("It appears you have exceeded the maximum number of attempts allowed.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                        }

                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                    attempts++;
                }
                else
                {
                    maxAttemptsExceeded = true;
                }
            }

            return userInteger;
        }

        /// <summary>
        /// helper method to get a valid positive integer from the user
        /// </summary>
        /// <param name="maxAttempts">maximum number of attempts</param>
        /// <param name="userPrompt">user prompt</param>
        /// <param name="validInput">indicates valid user input</param>
        /// <returns></returns>
        public static string GetYesNoFromUser(int maxAttempts, string userPrompt, out bool maxAttemptsExceeded)
        {
            bool validInput = false;
            maxAttemptsExceeded = false;
            string userResponse = "";
            int attempts = 1;

            while (!validInput && !maxAttemptsExceeded)
            {
                Console.Write($"{userPrompt} [Yes / No] ");
                userResponse = Console.ReadLine();
                Console.WriteLine();

                //
                // input is valid
                //
                if (userResponse.ToUpper() == "YES" || userResponse.ToUpper() == "NO")
                {
                    validInput = true;
                }
                //
                // input is invalid, but more attempts available
                //
                else
                {
                    Console.WriteLine($"You entered: {userResponse}");
                                        Console.WriteLine($"\"{userResponse}\" is not a valid response.");
                    
                    //
                    // more attempts available 
                    //
                    if (attempts < maxAttempts)
                    {
                        Console.WriteLine($"Please enter either \"Yes\" or \"No\".");
                        Console.WriteLine("Press any key to try again.");
                    }
                    //
                    // all attempts used
                    //
                    else
                    {
                        Console.WriteLine("It appears you have exceeded the maximum number of attempts allowed.");
                        Console.WriteLine("Press any key to continue.");
                        maxAttemptsExceeded = true;
                    }

                    Console.ReadKey();
                    Console.Clear();
                }

                attempts++;
            }

            return userResponse;
        }
    }
}
