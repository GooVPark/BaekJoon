using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._17단계
{
    internal class Main17_02
    {
        static void Main2(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int n = input[0];
            int interval = input[1];

            int[] tempers = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int sum = 0;
            for(int i = 0; i < interval; i++) sum += tempers[i];
            int max = sum;
            for(int i = 1; i + interval <= tempers.Length; i++)
            {
                sum = sum + tempers[i + interval - 1] - tempers[i - 1];
                if (sum > max) max = sum;
            }

            Console.WriteLine(max);
        }
    }
}
