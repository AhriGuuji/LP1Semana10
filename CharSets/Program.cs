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
            string thing;
            char[] c;
            HashSet<char> chars = new HashSet<char>();

            foreach(string arg in args)
            {
                using StreamReader readIt = new StreamReader(arg);

                while( ( thing = readIt.ReadLine()) != null)
                {
                    c = thing.ToCharArray();
                    if (c.Length > 1) { break; }
                    chars.Add(c[0]);
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
