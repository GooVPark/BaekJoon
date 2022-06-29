using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_07
    {
        static void Main7(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int n = int.Parse(sr.ReadLine());

            int[] sum = new int[n];
            int[] line1 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            if(n == 1)
            {
                Console.WriteLine(sum[0]);
                return;
            }

            int[] line2 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            sum[0] = line1[0] + line2[0];
            sum[1] = line1[0] + line2[1];

            if(n == 2)
            {
                Console.WriteLine(sum[0] > sum[1] ? sum[0] : sum[1]);
                return;
            }
            int[] input = new int[n];
            for(int i = 2; i < n; i++)
            {
                input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                input[0] += sum[0];

                for (int j = 1; j <= i; j++)
                {
                    int left = sum[j - 1];
                    int right = sum[j];

                    input[j] += left > right ? left : right;
                }
                for (int j = 0; j <= i; j++) sum[j] = input[j];
            }
            int max = int.MinValue;
            for(int i = 0; i < n; i++) if(max < sum[i]) max = sum[i];

            Console.WriteLine(max);
        }
    }
}
