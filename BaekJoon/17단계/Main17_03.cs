using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._17단계
{
    internal class Main17_03
    {
        static void Main3(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            char[] str = sr.ReadLine().ToCharArray();
            int n = int.Parse(sr.ReadLine());

            int[,] map = new int[27, str.Length + 1];

            for(int i = 1; i <= str.Length; i++)
            {
                for (int j = 0; j <= 26; j++)
                {
                    map[j, i] = map[j, i - 1];
                }

                int a = str[i-1] - 96;
                map[a, i]++;
            }

            for(int i = 0; i < n; i++)
            {
                string[] input = sr.ReadLine().Split();
                char a = Char.Parse(input[0]);
                int start = int.Parse(input[1]);
                int end = int.Parse(input[2]);

                sb.AppendLine((map[a - 96, end +1] - map[a - 96, start]).ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
