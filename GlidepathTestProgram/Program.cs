using System;
using System.Collections.Generic;

namespace GlidepathTestProgram
{
    class Program
    {
        // Main entry
        
        static void Main(string[] args)
        {
            ReadWriteFunctions rwFunction = new ReadWriteFunctions();
            int inputNumber = UserInput();

            ReadWriteFunctions.Wrtie(inputNumber);
            string last = ReadWriteFunctions.Read();
        }

        public static int UserInput()
        {
            Console.Write("Please enter number: ");

            int number = Convert.ToInt32(userInput());

            return number;
        }

        public static string userInput()
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int value))
            {
                Console.WriteLine("Please enter numeric value only");
                return input = Console.ReadLine();
            }
            else
                return input;
        }
    }
}