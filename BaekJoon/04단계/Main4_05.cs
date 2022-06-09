using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_05
    {
        static void Main5(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string[] temps = Console.ReadLine().Split();
            float[] scores = new float[count];
            float max = -1;

            for(int i = 0; i < count; i++)
            {
                scores[i] = int.Parse(temps[i]);
                if (scores[i] > max) max = scores[i];
            }

            float total = 0;
            for(int i = 0; i < count; i++)
            {
                scores[i] = scores[i] / max * 100;
                total += scores[i];
            }
            float avg = total / count;

            Console.WriteLine(avg);
        }
    }
}
