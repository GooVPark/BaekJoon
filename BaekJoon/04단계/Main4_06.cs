using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_06
    {
        static void Main6(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] scores = new int[count];

            for(int i = 0; i < count; i++)
            {
                string[] oSets = Console.ReadLine().Split('X');
                int total = 0;

                for(int j = 0; j < oSets.Length; j++)
                {
                    int part = 0;
                    for(int k = 1; k < oSets[j].Length + 1; k++)
                    {
                        part += k; 
                    }
                    total += part;
                }

                scores[i] = total;
            }

            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
