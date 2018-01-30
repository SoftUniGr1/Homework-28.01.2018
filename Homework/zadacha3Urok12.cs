using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3Urok12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int br = numbers.Length;
            int numberCheck = int.Parse(Console.ReadLine());
            for (int i=0; i<numbers.Length; i++)
            {
                if (numberCheck == numbers[i])
                {
                    Console.WriteLine("Yes");
                    break;
                }
                else { br--; }
            }
            if (br == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
