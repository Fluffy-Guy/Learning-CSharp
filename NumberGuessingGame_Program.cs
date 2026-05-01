using System;

namespace NumberGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inputs yo
            Console.WriteLine("Number guessing game, enter a number from 1-3.");
            Random rnd = new Random();
            int rightNum = rnd.Next(1, 3);
            string guessInput = Console.ReadLine();
            int guessResult = Convert.ToInt32(guessInput);

            // results
            if (guessResult.GetType() == typeof(int))
            {
                if (guessResult == rightNum)
                {
                    Console.WriteLine("You got it right, the number was " + rightNum);
                }
                else
                {
                    Console.WriteLine("You got it wrong, the number was " + rightNum);
                }
            }
            else
            {
                Console.WriteLine("Error, info: " + (guessInput.GetType() == typeof(int)));
            }
        }
    }
}
