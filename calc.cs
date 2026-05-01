using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user inputs and interface
            Console.WriteLine("This is my very very cool calculator, so like enter the stuff");

            Console.WriteLine("Enter first number: ");
            string FirstNumInput = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            string LastNumInput = Console.ReadLine();

            Console.WriteLine("Enter the math type (+, -, *, or /): ");
            string MathInput = Console.ReadLine();

            // converting input
            int FirstNumResult = Convert.ToInt32(FirstNumInput);
            int LastNumResult = Convert.ToInt32(LastNumInput);

            // math results
            if (MathInput == "+")
            {
                int FinalResult = FirstNumResult + LastNumResult;
                Console.WriteLine("The result is: " + FinalResult);
            }
            else if (MathInput == "-")
            {
                int FinalResult = FirstNumResult - LastNumResult;
                Console.WriteLine("The result is: " + FinalResult);
            }
            else if (MathInput == "*")
            {
                int FinalResult = FirstNumResult * LastNumResult;
                Console.WriteLine("The result is: " + FinalResult);
            }
            else if (MathInput == "/")
            {
                int FinalResult = FirstNumResult / LastNumResult;
                Console.WriteLine("The result is: " + FinalResult);
            }
            else
            {
                Console.WriteLine("Error, make sure you entered a valid number or math symbol.");
            }
        }
    }
}
