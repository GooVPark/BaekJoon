using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_04
    {
        static void Main4(string[] args)
        {
            string[] str = Console.ReadLine().Split();

            int moveMorning = int.Parse(str[0]);
            int moveNight = int.Parse(str[1]) * -1;
            int destance = int.Parse(str[2]);

            double days = (double)(destance + moveNight) / (double)(moveMorning + moveNight);

            Console.WriteLine(Math.Ceiling(days));
        }
    }
}
