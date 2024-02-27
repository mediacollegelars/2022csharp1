using System;
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor
                = ConsoleColor.Green;
            string text = "Hello, World";

            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(75);
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;

        
           

            // Display current Foreground color 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");

        }
    }
}
