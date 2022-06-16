using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._13단계
{
    internal class Main13_07
    {
        static void Main7(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int testCount = int.Parse(sr.ReadLine());

            for (int i = 0; i < testCount; i++)
            {
                int pass = 0;
                string[] points = sr.ReadLine().Split();
                int startX = int.Parse(points[0]);
                int startY = int.Parse(points[1]);
                int endX = int.Parse(points[2]);
                int endY = int.Parse(points[3]);

                int planetCount = int.Parse(sr.ReadLine());

                while(planetCount > 0)
                {
                    string[] planetInput = sr.ReadLine().Split();
                    int planetX = int.Parse(planetInput[0]);
                    int planetY = int.Parse(planetInput[1]);
                    int radius = int.Parse(planetInput[2]);
                    double distanceToStart = Math.Sqrt(Math.Pow(planetX - startX, 2) + Math.Pow(planetY - startY, 2));
                    double distanceToEnd = Math.Sqrt(Math.Pow(planetX - endX, 2) + Math.Pow(planetY - endY, 2));

                    if ((distanceToStart < radius && distanceToEnd > radius) || (distanceToStart > radius && distanceToEnd < radius)) pass += 1;
                    planetCount--;
                }
                sb.AppendLine(pass.ToString());
            }
            Console.WriteLine(sb);

        }
    }
}
