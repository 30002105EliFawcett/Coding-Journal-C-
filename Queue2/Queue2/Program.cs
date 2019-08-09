using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task2Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Queue q1 = new Queue();
            for (int i = 4; i > q1.Count; i++)
            {
                q1.Enqueue("jack");
                q1.Enqueue("steve");
                q1.Enqueue("mike");
                q1.Enqueue("rave");
                q1.Enqueue("jeff");
            }
            Console.WriteLine("Number of elements in Queue: " + q1.Count);
            Console.Write("Enter a name to search the Queue: ");
            name=(Console.ReadLine());
            Console.Write(q1.Contains(name));
           


        }
    }
}
