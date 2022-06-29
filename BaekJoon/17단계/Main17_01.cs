using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._17단계
{
    internal class Main17_01
    {
        static void Main1(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            int[] numbers = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] prefix = new int[input[0] + 1];

            for(int i = 1; i < prefix.Length; i++)
            {
                prefix[i] = numbers[i - 1] + prefix[i - 1];
            }

            for(int i = 0; i < input[1]; i++)
            {
                int[] section = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                sb.AppendLine((prefix[section[1]] - prefix[section[0] - 1]).ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
