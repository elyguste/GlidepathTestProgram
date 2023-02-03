using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace GlidepathTestProgram
{
    class Program
    {
        // Main entry
        
        public static void Main(string[] args)
        {
            ReadWriteFunctions rwFunction = new ReadWriteFunctions();
            int inputNumber = UserInput();

            string last = ReadWriteFunctions.Read();

            DataLogic(last, inputNumber);
        }

        public static int UserInput()
        {
            Console.Write("Please enter number: ");

            int number = Convert.ToInt32(CheckUserInput());

            return number;
        }

        public static string CheckUserInput()
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

        public static void DataLogic(string previousValue, int userInput)
        {
            string LastValue = previousValue.Split('|').Last();
        }
    }
}