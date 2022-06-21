using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_03
    {
        static long[] DP;
        static void Main3(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N == 0) 
            {
                Console.WriteLine(1);
                return; 
            }
            if (N == 1)
            {
                Console.WriteLine(1);
                return;
            }
            if (N == 2)
            {
                Console.WriteLine(2);
                return;
            }

            DP = new long[N + 1];
            DP[1] = 1;
            DP[2] = 2;

            for (int i = 3; i <= N; i++) DP[i] =( DP[i - 1] + DP[i - 2]) % 15746;

            Console.WriteLine(DP[N]);
        }   
    }
}
