using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._01단계
{
    internal class Main1_09
    {
        static void Main09(string[] args)
        {
            string[] nums = Console.ReadLine().Split();

            int num1 = int.Parse(nums[0]);
            int num2 = int.Parse(nums[1]);

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);
            
        }
    }
}
