// following the tutorial https://www.youtube.com/watch?v=GcFJjpMFJvI
using System;

// namespaces are containers for classes and functions
namespace NumberGuesser
{
    // main class
    internal class Program
    {
        // entry point method for our application
        // void: no return type
        // static: only one instance, referring to the function itself
        static void Main(string[] args)
        {
            // call getappinfo function
            GetAppInfo();

            // ask for user's name, greet them
            GreetUser();
            
            while (true)
            {
                // want to create new random object for random number
                Random random = new Random();

                // take random number and set it, within the bounds of 1 and 10
                int correctNumber = random.Next(1, 10);

                // set variable for guess
                int guess = 0;

                // ask user to guess a number
                Console.WriteLine("please guess a number between 1 and 10");

                // loop until the guess is correct
                while (guess != correctNumber)
                {
                    // get user's input (its always as a string
                    string input = Console.ReadLine();

                    // cast input into int 'guess' using try parse
                    // make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // print color message
                        PrintColorMessage(ConsoleColor.Red, "this isnt a number!!");

                        // keep going
                        continue;
                    }

                    // want to cast input into int 'guess'
                    // try catch?
                    // guess = Int32.Parse(input);

                    // tell user their guess was wrong
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "that is so wrong");
                    }
                }

                // if we get here then guess == correctNumber
                // output success message
                PrintColorMessage(ConsoleColor.Yellow, "you guessed it bro");


                // ask the user to play again
                Console.WriteLine("you want to play again? [Y or N]");

                // get answer, make it uppercase
                string answer = Console.ReadLine().ToUpper();

                // why would we check if its Y and continue? lol you
                // are literally in a while loop ...
                if (answer == "N")
                {
                    break;
                }
            }
        }

        // GetAppInfo() function
        // get and display app info
        static void GetAppInfo()
        {
            // setting app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "yelir4";

            // setting colors for our title text
            Console.ForegroundColor = ConsoleColor.Green;

            // print app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset color after printing title text
            Console.ResetColor();
        }
        
        // GreetUser() function
        // greet the user
        static void GreetUser()
        {
            // ask for the user's name
            Console.WriteLine("What is your name?");

            // get input, put into string
            string userName = Console.ReadLine();

            // welcome user, invite to play a game
            Console.WriteLine("Hello {0}, let's play a game!", userName);
        }

        // PrintColorMessage() function
        // print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("{0}", message);
            Console.ResetColor();
        }
    }
}
