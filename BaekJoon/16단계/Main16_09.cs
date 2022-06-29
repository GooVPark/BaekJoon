using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_09
    {
        static void Main9(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n + 1];

            if(n == 1)
            {
                Console.WriteLine("0");
                return;
            }
            if(n == 2)
            {
                Console.WriteLine("1");
                return;
            }

            numbers[1] = 0;
            numbers[2] = 1;
            numbers[3] = 1;

            for(int i = 4; i <= n; i++)
            {
                int temp = int.MaxValue;
                if(i % 3 == 0)
                {
                    temp = Min(temp, numbers[i / 3] + 1);
                }
                if(i % 2 == 0)
                {
                    temp = Min(temp, numbers[i / 2] + 1);
                }

                temp = Min(temp, numbers[i - 1] + 1);
                

                numbers[i] = temp;
            }

            Console.WriteLine(numbers[n]);
        }
        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
    }
}
