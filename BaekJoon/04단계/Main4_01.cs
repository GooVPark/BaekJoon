using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_01
    {
        static void Main1(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            int max = -1000001;
            int min = 1000001;
            for(int i = 0; i < count; i++)
            {
                int number = int.Parse(nums[i]);
                if (number > max) max = number;
                if (number < min) min = number; 
            }

            Console.WriteLine($"{min} {max}");
        }
    }
}
