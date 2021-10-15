using System;

// Namespace

namespace NumGuess
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
                     // LOGIC

            GetAppInfo(); // Calling opening function 

            Greeting(); // Greets user

            while (true)
            {
                 // Init correct number (FIXED)
                // int correctNumber = 7;

                // Create new random number/object
                Random random = new Random();

                // Init correct number (RANDOM)
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Prompt user
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string inputGuess = Console.ReadLine();

                    // Verify input is a number
                    if (!int.TryParse(inputGuess, out guess))
                    {
                        PrintColorMsg1();

                        // Keep program/game going
                        continue;
                    }

                    // Cast to int and put in guess var
                    guess = Int32.Parse(inputGuess);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMsg2();
                    }
                }

                // Output success message

                        PrintColorMsg3();

                // Prompt user to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }
                    // FUNCTIONS
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "koaScript";

            // Change bg color
            Console.BackgroundColor = ConsoleColor.Gray;

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset console color
            Console.ResetColor();
        }
        static void Greeting()
        {
            // Ask user name
            Console.WriteLine("Yo, what is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // Return greeting
            Console.WriteLine("What up {0}, let's play a game...", inputName);
        }

        static void PrintColorMsg1()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("NOT A NUMBER!!! IDIOT!");

            Console.ResetColor();
        }
        static void PrintColorMsg2()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Wrong number fool! Try again");

            Console.ResetColor();
        }
        static void PrintColorMsg3()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Congrats. Genius.");

            Console.ResetColor();
        }
    }
}
