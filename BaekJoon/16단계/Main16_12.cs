using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_12
    {
        static void Main12(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int n = int.Parse(sr.ReadLine());
            int[] input = new int[n+1];
            int[] lengths = new int[n+1];
            
            string[] str = sr.ReadLine().Split();
            for(int i = 0; i < n; i++) input[i+1] = int.Parse(str[i]);
            for (int i = 0; i < n; i++) lengths[i+1] = 1;
            int max = 1;

            for(int i = 1; i <= n; i++)
            {
                int maxIndex = 0;
                for(int j = i - 1; j >= 0; j--)
                {
                    if (input[maxIndex] < input[j] && input[j] < input[i] && lengths[maxIndex] <= lengths[j])
                    {
                        maxIndex = j;
                    }
                }

                lengths[i] = lengths[maxIndex] + 1;

                if (lengths[i] > max) max = lengths[i];
                //Console.WriteLine(String.Join(" ", lengths));
            }

            Console.WriteLine(max);
        }
    }
}
