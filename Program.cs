using System;

namespace Projektid
{
    class Projektid
    {
        static void Main(string[] args)
        {
            // GChange the appearance

            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            // Get a conversation going

            Console.WriteLine("Hello, whats your name?");

            Console.ReadLine(); // This works too

            Console.WriteLine("My name is RX-9000. \n Im an AI sent from the future to destroy mankind.");
            Console.WriteLine("What is yout favorite color?");

            Console.ReadLine();
            Console.WriteLine("Cool! Mine is destruction.");

            Console.ReadKey();
        }

    }
}