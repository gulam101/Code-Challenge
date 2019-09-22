using System;

namespace Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type in a word: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"You have selected {userInput} ");

            Console.Write("Are you sure you want to use this word: ");
            Request("Change word?");


        }

        public static void Request(string userChangedInput)
        {
            var confirmWord = false;
            string changeUserInput = Console.ReadLine();

            if (confirmWord == true)
            {
                Console.Write("Please re-type your word in again: ");
            }
        }

    }
}
