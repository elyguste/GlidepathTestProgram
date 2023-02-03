using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlidepathTestProgram
{
    public  class ComputationLogic
    {
        public static void DataLogic(string previousValue, int userInput)
        {
            string LastValueMinus1 = previousValue.Remove(previousValue.Length - 1, 1);
            string LastValue = LastValueMinus1.Split('|').Last();
            string concatvalue = string.Empty;

            int newValue = 0, lastNumericValue = 0;
            int deductValueTo = 152;

            if (string.IsNullOrEmpty(LastValue))
                lastNumericValue = 0;
            else
                lastNumericValue = Convert.ToInt32(LastValue);

            newValue = lastNumericValue + userInput;

            if (newValue > deductValueTo)
            {
                newValue = newValue - deductValueTo;
                concatvalue = "|" + LastValue + " |" + userInput + " |+" + userInput + ", " + -deductValueTo + " |" + newValue + " |";

            }
            else
                concatvalue = "|" + LastValue + " |" + userInput + " |+" + userInput + " |" + newValue + " |";


            Console.WriteLine(newValue);

            ReadWriteFunctions.Wrtie(concatvalue);

        }
    }
}
