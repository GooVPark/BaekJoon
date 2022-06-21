using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_06
    {
        static void Main6(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int count = int.Parse(sr.ReadLine());

            int[,] rgbs = new int[3, count];

            for(int i = 0; i < count; i++)
            {
                string[] input = sr.ReadLine().Split();
                for(int j = 0; j < 3; j++)
                {
                    rgbs[j, i] = int.Parse(input[j]);
                }
            }

            for(int i = 1; i < count; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    int n1 = (j + 1) % 3;
                    int n2 = (j + 2) % 3;
                    int m = rgbs[n1, i - 1] < rgbs[n2, i - 1] ? rgbs[n1, i - 1] : rgbs[n2, i - 1];
                    rgbs[j, i] += m;
                }
            }

            int min = int.MaxValue;
            for(int i = 0; i < 3; i++)
            {
                if (rgbs[i, count - 1] < min) min = rgbs[i, count - 1];
            }

            Console.WriteLine(min);
        }
    }
}
