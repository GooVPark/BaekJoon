using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._15단계
{
    internal class Main15_01
    {
        static bool[] visited;
        static int[] array;

        static StringBuilder sb;

        static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            sb = new StringBuilder();

            visited = new bool[N];
            array = new int[M];

            DFS(N, M, 0);

            Console.WriteLine(sb);
        }

        static void DFS(int N, int M, int depth)
        {
            if (M == depth)
            {
                for (int i = 0; i < M; i++) sb.Append(array[i] + " ");
                sb.AppendLine();
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        array[depth] = i + 1;
                        DFS(N, M, depth + 1);
                        visited[i] = false;
                    }
                }
            }
        }
    }
}
