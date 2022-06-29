using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._17단계
{
    internal class Main17_05
    {
        static void Main5(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder(); 
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int n = input[0];
            int t = input[1];

            int[,] map = new int[n + 1, n + 1];

            for(int i = 1; i <= n; i++)
            {
                input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 1; j <= n; j++)
                {
                    map[i, j] = input[j - 1] + map[i - 1, j] + map[i, j - 1] - map[i - 1, j - 1];
                }
            }

            for(int i = 0; i < t; i++)
            {
                input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                
                int startX = input[0];
                int startY = input[1];
                int endX = input[2];
                int endY = input[3];

                sb.AppendLine((map[endX, endY] - (map[startX -1, endY] + map[endX, startY -1] - map[startX -1, startY -1])).ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
