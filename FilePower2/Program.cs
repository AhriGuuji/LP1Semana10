using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            using StreamWriter file = new StreamWriter(args[0]);

            while (true)
            {
                string newLine = Console.ReadLine();
                if (string.IsNullOrEmpty(newLine)) {break;}
                else {file.WriteLine(newLine);}
            }
        }
    }
}
