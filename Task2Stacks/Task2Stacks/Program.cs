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
            Queue q1 = new Queue();
            for (int i = 4; i > q1.Count; i++) {
                q1.Enqueue("house");
                q1.Enqueue("once");
                q1.Enqueue(true);
                q1.Enqueue(1);
                q1.Enqueue(5.5);
                q1.Enqueue(5.5);
                q1.Enqueue(5.5);
            }
            Console.WriteLine("Number of elements in Queue: "+ q1.Count);

        }
    }
}
