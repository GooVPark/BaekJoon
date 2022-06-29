using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._18단계
{
    internal class Main18_01
    {
        static void Main1(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            int N = input[0];
            int K = input[1];

            int[] A = new int[K];

            for(int i = 0; i < N; i++) A[i] = int.Parse(sr.ReadLine());

            int index = N-1;
            int count = 0;

            while(K > 0)
            {
                if (K - A[index] >= 0)
                {
                    K -= A[index];
                    count++;
                }
                else
                {
                    index--;
                }
            }

            Console.WriteLine(count);
        }
    }
}
