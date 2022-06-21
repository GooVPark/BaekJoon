using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_04
    {
        static void Main4(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int count = int.Parse(sr.ReadLine());

            long[] N = new long[101];
            N[1] = 1;
            N[2] = 1;
            N[3] = 1;
            N[4] = 2;
            N[5] = 2;

            for(int i = 5; i <= 100; i++)
            {
                N[i] = N[i - 1] + N[i - 5];
            }

            for(int i = 0; i < count; i++)
            {
                int n = int.Parse(sr.ReadLine());
                sb.AppendLine(N[n].ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
