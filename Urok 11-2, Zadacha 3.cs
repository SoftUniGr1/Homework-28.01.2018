using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nai_dulga_posledovatelnost_ot_narastvashti_el
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int longestOrder = 1;
            int counter = 1;
            int lastNum = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1] + 1)
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > longestOrder)
                {
                    longestOrder = counter;
                    lastNum = nums[i];
                }
            }
            int firstNum = (lastNum - longestOrder) + 1;
            for (int i = firstNum; i <= lastNum; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
