using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type any key to continue... Then press 'Enter'");
            Console.WriteLine("Hello World!");
            // Assigns the user input value to the variable 'Read'
            string Read = Console.ReadLine();
            // Displays what the user inputed, along with another message
            Console.WriteLine("You typed '" + Read+ "'. Have a good day!");
        }
    }
}
