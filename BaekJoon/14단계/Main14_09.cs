using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_09
    {
        static void Main9(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int count = int.Parse(sr.ReadLine());
            int[,] map = new int[31, 31];

            for (int i = 0; i <= 30; i++) map[i, 0] = 1;
            for (int i = 0; i <= 30; i++) map[i, i] = 1;

            for(int i = 0; i < count; i++)
            {
                string[] input = sr.ReadLine().Split();
                int k = int.Parse(input[0]);
                int n = int.Parse(input[1]);

                Console.WriteLine(C(map, n, k));
            }
        }

        static int C(int[,] map, int n, int k)
        {
            if (n == k || n == 0)
            {
                map[n, k] = 1;
                return 1;
            }

            if (map[n, k] == 0)
            {
                return map[n, k] = (C(map, n - 1, k) + C(map, n - 1, k - 1));
            }
            else
            {
                return map[n, k];
            }
        }
    }
}
