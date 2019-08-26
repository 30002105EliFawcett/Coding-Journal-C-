using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            //RANDOM GENERATOR BETWEEN 100-999
            int[] nums = new int[100000];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(100, 999);
                Console.Write($"{nums[i]} ");
            }

            //DISPLAYS
            Console.WriteLine( );
            Console.Write(FindNum(nums));

            // Console.WriteLine(BinarySearch(nums));
            
        }

        //LINEAR SEARCH METHOD
        static int FindNum(int[] arr)
        {
            Console.Write("Please enter a number you want to find in the array: ");
            int search = Convert.ToInt32(Console.ReadLine());

            //CHECKS IF SEARCH IS IN THE ARRAY SEARCH IS TAKEN FROM USER
            for(int i =1; i < arr.Length; i++)
            {
                if (search == arr[i])
                {
                    Console.WriteLine("\nNumber FOUND!: ", search);
                }
                else Console.Write(" SCANNING: NOT FOUND ");
            }
            return search;
        }
        //BINARY SEARCH METHOD
        static int BinarySearch(int[] arr)
        {
            int binary = 10;

            return binary;
        }

    }
}
