using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._02단계
{
    internal class Main2_05
    {
        static void Main05(string[] args)
        {
            string[] str = Console.ReadLine().Split();

            int hour = int.Parse(str[0]);
            int minute = int.Parse(str[1]);

            int time = (hour * 60) + minute;
            if (time < 45)
            {
                time = (1440 + time) - 45;
            }
            else time -= 45;

            Console.WriteLine($"{time / 60} {time % 60}");
        }
    }
}
