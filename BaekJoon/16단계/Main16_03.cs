using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_03
    {
        static int count = 0;
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            DFS(N, 0, 0);

            Console.WriteLine(count);
        }

        static void DFS(int N, int n0, int n1)
        {
            if(N == n0 + n1)
            {
                count++;
            }
            if (N < n0 + n1) return;

            DFS(N, n0 + 2, n1); 
            DFS(N, n0, n1 + 1);
        }
    }
}
