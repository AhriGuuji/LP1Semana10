using System;
using System.Collections.Generic;
using System.IO;

namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {

            List<char> chars1 = new List<char>();

            foreach(string arg in args)
            {
                string wRizz = File.ReadAllText(arg);
                
                foreach (char letter in wRizz)
                {
                    if (!char.IsWhiteSpace(letter) && !chars1.Contains(letter))
                    {
                        chars1.Add(letter);
                    }
                }
            }
        
            chars1.Sort();
            
            foreach(char letter in chars1)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
