using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_02
    {
        static void Main2(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int[,,] map = new int[21, 21, 21];

            while(true)
            {
                string input = sr.ReadLine();
                if(input == "-1 -1 -1")
                {
                    break;
                }

                int a = int.Parse(input.Split()[0]);
                int b = int.Parse(input.Split()[1]);
                int c = int.Parse(input.Split()[2]);

                sb.AppendLine($"w({a}, {b}, {c}) = {W(a, b, c, map)}");
            }

            Console.WriteLine(sb);
        }

        static int W(int a, int b, int c, int[,,] map)
        {
            if(a <= 0 || b <= 0 || c <= 0)
            {
                return 1;
            }
            else if(a > 20 || b > 20 || c > 20)
            {
                return W(20, 20, 20, map);
            }
            else if (map[a, b, c] != 0)
            {
                return map[a, b, c];
            }
            else if(a < b && b < c)
            {
                map[a, b, c] = W(a, b, c - 1, map) + W(a, b - 1, c - 1, map) - W(a, b - 1, c, map);
                return map[a, b, c];
            }
            else
            {
                map[a, b, c] = W(a - 1, b, c, map) + W(a - 1, b - 1, c, map) + W(a - 1, b, c - 1, map) - W(a - 1, b - 1, c - 1, map);
                return map[a, b, c];
            }
        }
    }
}
