using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._15단계
{
    internal class Main15_05
    {
        static int count = 0;
        static int[] queens;
        static int N;
        static void Main5(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            queens = new int[N];

            DFS(0);

            Console.WriteLine(count);
        }

        static void DFS(int depth)
        {
            if (N == depth)
            {
                count++;
                return;
            }

            for (int i = 0; i < N; i++)
            {
                if(Check(i, depth))
                {
                    queens[depth] = i;
                    DFS(depth + 1);
                }
            }
        }

        static bool Check(int i, int depth)
        {
            for(int j = 0; j < depth; j++)
            {
                if (queens[j] == i || Math.Abs(queens[j] - i) == Math.Abs(j - depth)) return false;
            }

            return true;
        }
    }
}
