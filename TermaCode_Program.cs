using System;
using System.Data;
using System.Xml;

namespace TermalCode
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to TermalCode, a command system that translates to C# for little jits who cant code.\n\nType '/help' to start");
            bool safeToRun = true;
            while (safeToRun == true)
                if (safeToRun == true)
                {
                    Command(Console.ReadLine());
                }
                else
                {
                    Error("Program Refused to comply.");
                }
        }
        static void Command(string userInput)
        {
            userInput.ToLower();
            if (userInput == "/help")
            {
                Help();
            }
            else if (userInput.StartsWith("/say "))
            {
                userInput = userInput.Substring(5);
                Say(userInput);
            }
            else
            {
                Error("Unkown command.");
            }
        }
        static void Say(string userInput)
        {
            Console.WriteLine(userInput);
        }
        static void Help()
        {
            Console.WriteLine("Helps");
        }
        static void Error(string reason)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error: " + reason);
            Console.Error.WriteLine();
            Console.ResetColor();
        }
    }
}
