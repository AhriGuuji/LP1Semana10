using System;
using System.Collections.Generic;
using System.Text;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] array = {1, 10, -30, 10, -5};

            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            HashSet<int> hashSet = new HashSet<int>();

            foreach (int i in array)
            {
                list.Add(i);
                stack.Push(i);
                queue.Enqueue(i);
                hashSet.Add(i);
            }
            
            PrintCollection(list);
            PrintCollection(stack);
            PrintCollection(queue);
            PrintCollection(hashSet);
        }

        private static void PrintCollection<T>(IEnumerable<T> collection)
        {
            string fullName = collection.GetType().Name;
            int backtickIndex = fullName.IndexOf('`');
            if (backtickIndex > 0) fullName = fullName.Substring(0, backtickIndex);
            StringBuilder stringBuilder = new StringBuilder($"{fullName}: ");
            foreach (var item in collection)
            {
                stringBuilder.Append(item + ", ");
            }
            Console.WriteLine(stringBuilder.ToString().Substring(0, stringBuilder.Length - 2));
        }
        
    }
}
