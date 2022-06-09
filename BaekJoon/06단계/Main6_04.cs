using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_04
    {
        static void Main4(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < count; i++)
            {
                string[] str = Console.ReadLine().Split();
                int repeat = int.Parse(str[0]);

                for(int j = 0; j < str[1].Length; j++)
                {
                    for(int k = 0; k < repeat; k++) sb.Append(str[1][j]);
                }
                sb.Append("\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
