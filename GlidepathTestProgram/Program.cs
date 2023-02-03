using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;

namespace GlidepathTestProgram
{
    class Program
    {
        // Main entry

        public static void Main(string[] args)
        {
            //calling of input function
            int inputNumber = UserInput();

            //calling readline function
            string last = ReadWriteFunctions.Read();

            //computation logic and writing on the textfile
            ComputationLogic.DataLogic(last, inputNumber);
        }

        //input function
        public static int UserInput()
        {
            Console.Write("Please enter number: ");

            int number = Convert.ToInt32(CheckUserInput());

            return number;
        }

        //checking of user input
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
    }
}