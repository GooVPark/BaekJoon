using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_14
    {
        static void Main14(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int n = int.Parse(sr.ReadLine());

            int[] nums = new int[501];
            

            for(int i = 0; i < n; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                nums[input[0]] = input[1];
            }

            int[] dp = new int[n + 1];
            int[] lengths = new int[n + 1];
            for (int i = 0; i < n; i++) lengths[i + 1] = 1;
            int cnt = 1;
            for(int i = 1; i <= 501; i++)
            {
                if (nums[i -1] != 0)
                {
                    dp[cnt] = nums[i-1];
                    cnt++;
                }
            }

            int max = 1;

            for (int i = 1; i <= n; i++)
            {
                int maxIndex = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (dp[maxIndex] < dp[j] && dp[j] < dp[i] && lengths[maxIndex] <= lengths[j])
                    {
                        maxIndex = j;
                    }
                }

                lengths[i] = lengths[maxIndex] + 1;

                if (lengths[i] > max) max = lengths[i];
            }

            Console.WriteLine(n - max);
        }
    }
}
