using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vmukvane_na_element_v_sortiran_masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] newArray = new int[inputArray.Length + 1];
            int counter = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (n > inputArray[i])
                {
                    newArray[i] = inputArray[i];
                }
                if (counter == 0)
                {
                    if (n < inputArray[i])
                    {
                        newArray[i] = n;
                        counter++;
                    }
                }
                else if (counter > 0)
                {
                    for (int j = i; j < newArray.Length; j++)
                    {
                        newArray[j] = inputArray[j - 1];
                    }
                    break;
                }
            }
            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
