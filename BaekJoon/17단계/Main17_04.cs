using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._17단계
{
    internal class Main17_04
    {
        static void Main4(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            int n = input[0];
            int m = input[1];

            input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            int sum = 0;
            int[] remainder = new int[m];

            for(int i = 0; i < n; i++)
            {
                sum += input[i];
                remainder[sum % m]++;
            }

            int count = remainder[0];
            for(int i = 0; i < m; i++)
            {
                int a = remainder[i];
                count += a * (a - 1) / 2;
            }

            Console.WriteLine(count);
        }
    }
}
