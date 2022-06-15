using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._13단계
{
    internal class Main13_03
    {
        static void Main3(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            string input = string.Empty;

            while(true)
            {
                input = sr.ReadLine();
                if (input == "0 0 0") break;
                int[] nums = new int[3];
                for(int i = 0; i < 3; i++)
                {
                    nums[i] = int.Parse(input.Split()[i]);
                }

                Array.Sort(nums);
                if (Math.Pow(nums[0], 2) + Math.Pow(nums[1], 2) == Math.Pow(nums[2], 2)) sb.AppendLine("right");
                else sb.AppendLine("wrong");
            }
            Console.WriteLine(sb);
        }
    }
}
