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
            using (StreamWriter writer = new StreamWriter("Wfile.txt", true))
            {
                writer.WriteLine(writeToFile);
            }
        }

        public static string Read()
        {
            String lastRow = File.ReadLines("Wfile.txt").Last();
            return lastRow;

        }
    }
}
