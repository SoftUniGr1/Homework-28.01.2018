using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5Urok12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sortNumbers = new int[listNumbers.Length];
            int br = 0;
            int min = 0;
            for (int i1=0; i1<listNumbers.Length; i1++)
            {
                for (int i2=0; i2<listNumbers.Length-1; i2++)
                {
                    if (listNumbers[i2] > listNumbers[i2+1])
                    {
                        min = listNumbers[i2];
                        listNumbers[i2] = listNumbers[i2+1];
                        listNumbers[i2 + 1] = min;
                    }
                }
                
            }
                Console.WriteLine(string.Join(" ", listNumbers));
        }
    }
}
