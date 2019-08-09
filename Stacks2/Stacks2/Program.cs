using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stacks2
{
    class Program
    {
        /*
    Create an application that uses a loop to store integer values
    input by the user in a stack. Your application needs to
    display the numbers in reverse order back to the user.
        */
        static void Main(string[] args)
        {
            Stack s1 = new Stack();

            Console.Write("How many numbers would you like to input: ");
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                for (int i = 0; s1.Count < 6; i++)
                {
                    Console.WriteLine("Please enter INT values");
                    s1.Push(int.Parse(Console.ReadLine()));
                }
            }
            int end = s1.Count;
            Console.WriteLine("Showing Values Backwards");
            for (int i = 0; i < end; i++)
            {
                Console.WriteLine(s1.Pop());
            }

        }
    }
}
