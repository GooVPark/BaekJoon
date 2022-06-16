using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._13단계
{
    internal class Main13_06
    {
        static void Main6(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int count = int.Parse(sr.ReadLine());

            for(int i = 0; i < count; i++)
            {
                string[] input = sr.ReadLine().Split();

                int x1 = int.Parse(input[0]);
                int y1 = int.Parse(input[1]);
                double r1 = double.Parse(input[2]);
                int x2 = int.Parse(input[3]);
                int y2 = int.Parse(input[4]);
                double r2 = double.Parse(input[5]);
                
                if(x1 == x2 && y1 == y2)
                {
                    if (r1 == r2) sb.AppendLine("-1");
                    else sb.AppendLine("0");

                    continue;
                }

                double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double l = r1 > r2 ? r1 : r2;
                double s = r1 < r2 ? r1 : r2;

                if(distance < l)
                {
                    if(distance + s == l)
                    {
                        sb.AppendLine("1");
                    }
                    else if(distance + s > l)
                    {
                        sb.AppendLine("2");
                    }
                    else if(distance + s < l)
                    {
                        sb.AppendLine("0");
                    }
                }
                else
                {
                    if (distance > r1 + r2) sb.AppendLine("0");
                    else if (distance < r2 + r1) sb.AppendLine("2");
                    else sb.AppendLine("1");
                }
                
            }

            Console.WriteLine(sb);
        }
    }
}
