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
        }
    }
}


