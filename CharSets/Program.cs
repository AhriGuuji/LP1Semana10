using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {

            char[] c = new char[1];
            HashSet<char> chars = new HashSet<char>();

            foreach(string arg in args)
            {
                string wRizz = File.ReadAllText(arg);
                
                foreach (char letter in wRizz)
                {
                    chars.Add(letter);
                }
            }

            List<char> chars1 = new List<char>(chars);
            chars1.Sort();

            foreach(char letter in chars1)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
