using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_11
    {
        static void Main11(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int n = int.Parse(sr.ReadLine());
            int[] nums = new int[n + 3];
            int[] sums = new int[n + 3];

            for (int i = 3; i < n + 3; i++) nums[i] = int.Parse(sr.ReadLine());

            int max = 0;

            for (int i = 3; i < n + 3; i++)
            {
                sums[i] = Max(sums[i - 3] + nums[i] + nums[i - 1], sums[i - 2] + nums[i]);
                sums[i] = Max(sums[i - 1], sums[i]);
            }

            for(int i = 0; i < sums.Length; i++) if (sums[i] > max) max = sums[i];

            Console.WriteLine(max);
        }

        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
