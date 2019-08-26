using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100000];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(100, 300);
                Console.WriteLine(nums[i]);
            }
            

        }

    }
}
