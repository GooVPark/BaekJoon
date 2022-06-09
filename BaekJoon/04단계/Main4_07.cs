using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_07
    {
        static void Main7(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double[] answers = new double[count];

            for(int testCase = 0; testCase < count; testCase++)
            {
                string[] str = Console.ReadLine().Split();
                int studentCounts = int.Parse(str[0]);
                int[] scores = new int[studentCounts];
                int total = 0;
                for (int i = 0; i < studentCounts; i++)
                {
                    scores[i] = int.Parse(str[i + 1]);
                    total += scores[i];
                }
                double avg = total / studentCounts;
                int uppers = 0;
                foreach (int score in scores) if (score > avg) uppers++;
                double percent = (double)uppers / studentCounts * 100;
                answers[testCase] = percent;
            }

            for(int i = 0; i < count; i++)
            {
                string avgStr = string.Format("{0:0.000}", answers[i]);
                Console.WriteLine(avgStr + "%");
            }
        }
    }
}
