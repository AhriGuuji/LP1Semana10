using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string file = args[0];
            Queue<string> queueLines = new Queue<string>();

            while (true)
            {
                string newLine = Console.ReadLine();
                if (string.IsNullOrEmpty(newLine)) {break;}
                else {queueLines.Enqueue(newLine);}
            }

            File.WriteAllLines(file, queueLines);
        }
    }
}
