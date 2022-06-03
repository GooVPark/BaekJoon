using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._01단계
{
    internal class Main1_12
    {
        static void Main12(string[] args)
        {
            string[] nums = Console.ReadLine().Split();

            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);
            int c = int.Parse(nums[2]);

            Console.WriteLine((a + b) % c);
            Console.WriteLine(((a % c) + (b % c))%c);
            Console.WriteLine((a * b % c));
            Console.WriteLine(((a % c) * (b % c)) % c);
        }
    }
}
