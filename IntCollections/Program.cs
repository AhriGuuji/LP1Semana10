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
            
            Console.WriteLine("List: " + String.Join(", ", list));
            Console.WriteLine("Stack : " + String.Join(", ", stack));
            Console.WriteLine("Queue : " + String.Join(", ", queue));
            Console.WriteLine("Hashset : " + String.Join(", ", hashSet));
        }
        
    }
}
