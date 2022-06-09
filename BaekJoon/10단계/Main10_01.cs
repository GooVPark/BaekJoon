using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._10단계
{
    internal class Main10_01
    {
        static void Main1(string[] args)
        {
            string[] strs = Console.ReadLine().Split();
            int count = int.Parse(strs[0]);
            int number = int.Parse(strs[1]);

            string[] strs2 = Console.ReadLine().Split();
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++) numbers[i] = int.Parse(strs2[i]);

            int interval = number;
            int result = 0;

            for(int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    for(int k = j + 1; k < count; k++)
                    {
                        int sum = numbers[i] + numbers[j] + numbers[k];
                        int sub = number - sum;

                        if (sub >= 0 && sub <= interval)
                        {
                            interval = sub;
                            result = sum;
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
