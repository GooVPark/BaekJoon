using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._10단계
{
    internal class Main10_03
    {
        static void Main3(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] weights = new int[count];
            int[] heights = new int[count];

            int[] ranking = new int[count];

            for(int i = 0; i < count; i++)
            {
                string[] str = Console.ReadLine().Split();
                weights[i] = int.Parse(str[0]);
                heights[i] = int.Parse(str[1]);
                ranking[i] = 1;
            }

            for(int i = 0; i < count; i++)
            {
                for(int j = 0; j < count; j++)
                {
                    if (weights[i] < weights[j] && heights[i] < heights[j] && i != j)
                    {
                        ranking[i]++;
                    }
                }
            }

            for(int i = 0; i < count; i++)
            {
                Console.Write(ranking[i] + " ");
            }
        }
    }
}
