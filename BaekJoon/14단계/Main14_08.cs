using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_08
    {
        static void Main8(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int[,] map = new int[n + 1, n + 1];

            for (int i = 0; i <= n; i++) map[i, 0] = 1;
            for (int i = 0; i <= n; i++) map[i, i] = 1;

            Console.WriteLine(C(map, n, k));
        }

        static int C(int[,] map, int n, int k)
        {
            if(n == k || n == 0)
            {
                map[n, k] = 1;
                return 1;
            }

            if (map[n, k] == 0)
            {
                return map[n, k] = (C(map, n - 1, k) + C(map, n - 1, k - 1)) % 10007;
            }
            else
            {
                return map[n, k];
            }
        }
    }
}
