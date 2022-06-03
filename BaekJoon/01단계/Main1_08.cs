using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._01단계
{
    internal class Main1_08
    {
        static void Main08(string[] args)
        {
            string[] nums = Console.ReadLine().Split();

            Console.WriteLine(int.Parse(nums[0]) / int.Parse(nums[1]));
        }
    }
}
