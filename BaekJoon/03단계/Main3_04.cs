﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_04
    {
        static void Main4(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < count; i++)
            {
                string[] nums = Console.ReadLine().Split();
                int num1 = int.Parse(nums[0]);
                int num2 = int.Parse(nums[1]);

                sb.Append(num1 + num2 + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
