using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_13
    {
        static void Main13(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int n = int.Parse(sr.ReadLine());
            int[] input = new int[n + 2];
            int[] lengthLeft = new int[n + 2];
            int[] lengthRight = new int[n + 2];

            string[] str = sr.ReadLine().Split();
            for (int i = 0; i < n; i++) input[i + 1] = int.Parse(str[i]);
            for (int i = 0; i < n; i++) lengthLeft[i + 1] = 1;
            for (int i = 0; i < n; i++) lengthRight[i + 1] = 1;


            for (int i = 1; i <= n; i++)
            {
                int maxIndex = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (input[maxIndex] < input[j] && input[j] < input[i] && lengthLeft[maxIndex] <= lengthLeft[j])
                    {
                        maxIndex = j;
                    }
                }

                lengthLeft[i] = lengthLeft[maxIndex] + 1;
            }

            for(int i = n + 1; i >= 0; i--)
            {
                int maxIndex = 0;
                for(int j = i; j <= n + 1; j++)
                {
                    if (input[maxIndex] < input[j] && input[j] < input[i] && lengthRight[maxIndex] <= lengthRight[j])
                    {
                        maxIndex = j;
                    }
                }

                lengthRight[i] = lengthRight[maxIndex] + 1;
            }

            int max = 1;

            for(int i = 0; i < n + 2; i++)
            {
                if (max < lengthRight[i] + lengthLeft[i]) max = lengthLeft[i] + lengthRight[i];
            }

            Console.WriteLine(max - 1);
        }
    }
}
