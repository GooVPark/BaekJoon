using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._02단계
{
    internal class Main2_06
    {
        static void Main06(string[] args)
        {
            string[] str1 = Console.ReadLine().Split();
            string str2 = Console.ReadLine();

            int hour = int.Parse(str1[0]);
            int minute = int.Parse(str1[1]);
            int timer = int.Parse(str2);

            int time = (hour * 60) + minute;
            int result;

            if (time + timer >= 1440) result = (time + timer) - 1440;
            else result = time + timer;

            Console.WriteLine($"{result / 60} {result % 60}");
        }
    }
}
