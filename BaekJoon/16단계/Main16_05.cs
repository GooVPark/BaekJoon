using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_05
    {
        static int count = 0;
        static int[] nums;
        static int[] sums;
        static int max = int.MinValue;
        static void Main5(string[] args)
        {
            count = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            nums = new int[count + 1];
            sums = new int[count];
            for(int i = 1; i <= count; i++) nums[i] = int.Parse(input[i - 1]);

            for (int i = 1; i <= count; i++)
            {
                if (nums[i - 1] + nums[i] > nums[i])
                {
                    nums[i] = nums[i - 1] + nums[i];
                }

                if (nums[i] > max) max = nums[i];
            }

            Console.WriteLine(max);
        }
    }
}
