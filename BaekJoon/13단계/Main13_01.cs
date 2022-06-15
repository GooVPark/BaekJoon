using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._13단계
{
    internal class Main13_01
    {
        static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int posX = int.Parse(input[0]);
            int posY = int.Parse(input[1]);
            int width = int.Parse(input[2]);
            int height = int.Parse(input[3]);

            int distanceX = posX < width - posX ? posX : width - posX;
            int distanceY = posY < height - posY ? posY : height - posY;

            int shotest = distanceX < distanceY ? distanceX : distanceY;

            Console.WriteLine(shotest);
        }
    }
}
