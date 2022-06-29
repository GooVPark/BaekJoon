using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_16
    {
        static void Main16(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            int n = input[0];
            int l = input[1];

            int[] items = new int[l + 1];
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int weight = input[0];
                int value = input[1];

                for (int j = l; j >= weight; j--)
                {
                    items[j] = Max(items[j], items[j - weight] + value);
                    //Console.WriteLine(string.Join(" ", items));
                }
            }

            for (int i = 0; i <= l; i++) max = Max(max, items[i]);

            Console.WriteLine(max);
        }

        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
