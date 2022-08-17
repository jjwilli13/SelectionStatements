using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess my favorite number.");
            Console.WriteLine("Hint, the number is between 1 and 25");
            

            var r = new Random();
            var favNumber = r.Next(1, 25);
            int userInput;

            do
            {
                Console.WriteLine("Take your guess:");

               userInput = int.Parse(Console.ReadLine());

                if (userInput > favNumber)
                {
                    Console.WriteLine("Too High");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("Nevermind");
                }
            } while (userInput != favNumber );
            




        }
    }
}

