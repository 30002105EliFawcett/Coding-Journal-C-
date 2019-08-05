using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            s1.Push("one");
            s1.Push("house");
            s1.Push(1);
            s1.Push("$");
            s1.Push("32");
            s1.Push(16);
            s1.Push(true);
            s1.Push(false);
            s1.Push(1.23);
            s1.Push(61);
            Console.WriteLine("count: "+ s1.Count);
            Console.WriteLine("Peek: "+ s1.Peek());

            if (s1.Contains(true))
            {
                Console.WriteLine("Deleting: "+ s1.Pop());
                Console.WriteLine("Deleting: " + s1.Pop());
                Console.WriteLine("Deleting: " + s1.Pop());
            }
            Console.WriteLine("Number of Objects in the Stack: "+ s1.Count);


        }
    }
}
