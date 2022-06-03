using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._02단계
{
    internal class Main2_01
    {
        static void Main01(string[] args)
        {
            string[] nums = Console.ReadLine().Split();

            int num1 = int.Parse(nums[0]);
            int num2 = int.Parse(nums[1]);

            if(num1 > num2)
            {
                Console.WriteLine(">");
            }
            else if(num1 < num2)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
