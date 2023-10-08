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
            
            // Get a conversation going

            Console.WriteLine("A proud knight named...");

            Console.ReadLine(); // This works too

            Console.WriteLine("... walked into a bar. At the counter he met a...");
            
            Console.ReadLine();

            Console.WriteLine(".... who asked him what he wanted to drink?");

            Console.ReadLine();

            Console.WriteLine("...shouted the knight! The bartneder sushed him quickly");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("But it was too late... A dragon ate them both.");

            Console.ReadKey();
        }

    }
}