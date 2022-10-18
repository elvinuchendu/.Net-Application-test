using System;

//Namespace
namespace NumberGuesser
{
    //main Class
    internal class Program
    {
        // Entry Point Method
        public static void Main(string[] args)
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Elvin Uchendu";
            
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            
            //
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
        }
    }
}