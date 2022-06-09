using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_02
    {
        static void Main2(string[] args)
        {
            int[] nums = new int[9];

            int min = -1;
            int minIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                if (nums[i] > min)
                {
                    min = nums[i];
                    minIndex = i;
                }
            }

            Console.WriteLine($"{min}\n{minIndex + 1}");
        }
    }
}
