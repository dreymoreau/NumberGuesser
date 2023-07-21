// See https://aka.ms/new-console-template for more information
using System;

//namespace
namespace NumberGuesser
{
    //main class
    class Program
    {
        // entry point
        static void Main(string[] args)
        {
            // set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Drey Moreau";

            // change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text colour after app info
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game!", inputName);

            // Initialize correct number
            int correctNumber = 7;

            // Initialize guess variable
            int guess = 0;

            // ask user for number
            Console.WriteLine("Guess a number between 1 and 10");
            
            // while guess is not correct
            while (guess != correctNumber) {
                // get user input
                string input = Console.ReadLine();

                //take input and parse string into a int and put into
                // guess variable

                guess = Int32.Parse(input);

                //Match guess to correct number
                if (guess != correctNumber) {
                    // change text colour to red for error message
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Write out error message
                    Console.WriteLine("Wrong number, please try again");

                    // reset text colour after app info
                    Console.ResetColor();
                }
            }
            // change text colour to red for error message
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Tell User they chose the right number
            Console.WriteLine("You are correct!");

            // reset text colour after app info
            Console.ResetColor();
        }
    }
}


