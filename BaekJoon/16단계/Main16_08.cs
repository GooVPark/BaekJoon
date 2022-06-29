using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_08
    {
        static void Main8(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int n = int.Parse(sr.ReadLine());
            int[] stair = new int[n];
            int[] input = new int[n];
            for (int i = 0; i < n; i++) input[i] = int.Parse(sr.ReadLine());
            int maxScore = 0;

            stair[0] = input[0];
            if (n == 1) { Console.WriteLine(stair[0]); return; }
            stair[1] = Max(input[0] + input[1], input[1]);
            if (n == 2) { Console.WriteLine(stair[1]); return; }
            stair[2] = Max(input[0] + input[2], input[1] + input[2]);


            for (int i = 3; i < n; i++)
            {
                stair[i] = Max(stair[i - 3] + input[i - 1] + input[i], stair[i - 2] + input[i]);
                Console.WriteLine(String.Join(" ", stair));
                maxScore = stair[i];
            }

            Console.WriteLine(maxScore);
        }

        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
