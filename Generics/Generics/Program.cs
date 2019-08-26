using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            string first1; 
            string second;
            Console.WriteLine("Please enter a number and a string");
            Console.Write("Please enter a number: ");
            first=Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a string: ");
            second=Console.ReadLine();

            first1 = first.ToString();

            if (Generic<string>(first1, second))
                Console.WriteLine("They are the same");
            else
                Console.WriteLine($"They are different: \n first  = {first1} string = {second}  ");


     
        }

        public static bool Generic<T>(T first, T second)
        {
            if (first.Equals(second))
                return true;
            else
                return false;
        }
    }
}
