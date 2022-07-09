using System;

namespace String_Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string here: ");
            // Read the user input
            string input = Console.ReadLine();

            Console.Write("Enter a Character to search for: ");
            // Read the input to search for
            char searchInput = Console.ReadLine()[0];
            // Gets the index of the character from the string
            int searchIndex = input.IndexOf(searchInput);
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);

            Console.Write("Enter first name: ");
            // Read the first name
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            // Read the last name
            string lastName = Console.ReadLine();

            // concatenate first name and last name to make a sentence
            string fullName = string.Concat(firstName, " ", lastName);
            // Prints the full name on the console
            Console.WriteLine("Your full name is {0}", fullName);

            Console.ReadKey();
        }
    }
}
