using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_15
    {
        static void Main15(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            char[] input1 = sr.ReadLine().ToCharArray();
            char[] input2 = sr.ReadLine().ToCharArray();

            int[,] dp = new int[input1.Length + 1, input2.Length + 1];

            int max = 0;

            for (int i = 1; i <= input1.Length; i++)
            {
                for (int j = 1; j <= input2.Length; j++)
                {
                    if (input1[i - 1] == input2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Max(dp[i, j - 1], dp[i - 1, j]);
                    }

                    if (dp[i, j] > max) max = dp[i, j];
                }
            }

            Console.WriteLine(max);
        }

        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
