using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace GlidepathTestProgram
{
    public class ReadWriteFunctions
    {
        public static void Wrtie(string writeToFile)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Wfile.txt", true))
                {
                    writer.WriteLine(writeToFile);
                }
            }
            catch (Exception e)
            {
            }
        }

        public static string Read()
        {
            String lastRow = string.Empty;
            try
            {
                lastRow = File.ReadLines("Wfile.txt").Last();

            }
            catch (Exception e)
            {
                return "|";
            }

            return lastRow;
        }
    }
}
