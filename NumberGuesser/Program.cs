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

            // run GetAppInfo function to get info
            GetAppInfo();

            // ask for users name and greet
            GreetUser(); 

            while (true)
            {

                // Initialize correct number
                // int correctNumber = 7;


                // create a new random object to end up choosing a random number
                Random random = new Random();

                // generates a random number from 1 to 10
                int correctNumber = random.Next(1, 10);

                // Initialize guess variable
                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // get user input
                    string input = Console.ReadLine();

                    // make sure its a number, if not will prompt again
                    if (!int.TryParse(input, out guess))
                    {
                        // change text colour to red for error message
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell user it is not a number
                        Console.WriteLine("Please enter a number");

                        // reset text colour after app info
                        Console.ResetColor();

                        //keep going

                        continue;
                    }

                    //take input and parse string into a int and put into
                    // guess variable

                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
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

                // Ask user to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer

                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // get and display app info
        static void GetAppInfo() {

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
        }

        //ask users name and greet
        static void GreetUser() {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game!", inputName);
        }
    }
}


