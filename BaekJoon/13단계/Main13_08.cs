using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._13단계
{
    internal class Main13_08
    {
        static void Main8(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split();

            int w = int.Parse(input[0]);
            int h = int.Parse(input[1]);
            int x = int.Parse(input[2]);
            int y = int.Parse(input[3]);

            int count = int.Parse(input[4]);

            int leftCircleX = x;
            int leftCircleY = y + h / 2;
            int rightCircleX = x + w;
            int rightCircleY = y + h / 2;

            int squareStartX = x;
            int squareStartY = y;
            int squareEndX = x + w;
            int squareEndY = y + h;

            int radius = h / 2;

            int playerCount = 0;

            for(int i = 0; i < count; i++)
            {
                string[] playerInput = sr.ReadLine().Split();
                int playerX = int.Parse(playerInput[0]);
                int playerY = int.Parse(playerInput[1]);

                double distanceLeft = Math.Sqrt(Math.Pow(leftCircleX - playerX, 2) + Math.Pow(leftCircleY - playerY, 2));
                double distanceRight = Math.Sqrt(Math.Pow(rightCircleX - playerX, 2) + Math.Pow(rightCircleY - playerY, 2));

                if ((distanceLeft <= radius || distanceRight <= radius) || ((playerX >= squareStartX && playerY >= squareStartY) && (playerX <= squareEndX && playerY <= squareEndY))) playerCount++;
            }

            Console.WriteLine(playerCount);
        }
    }
}
