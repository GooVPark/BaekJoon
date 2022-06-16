using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_01
    {
        static void Main1(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            while(true)
            {
                string[] input = sr.ReadLine().Split();
                int n1 = int.Parse(input[0]);
                int n2 = int.Parse(input[1]);

                if(n1 > n2)
                {
                    if (n1 % n2 == 0) sb.AppendLine("multiple");
                    else sb.AppendLine("neither");
                }
                else if(n1 < n2)
                {
                    if (n2 % n1 == 0) sb.AppendLine("factor");
                    else sb.AppendLine("neither");
                }
                else
                {
                    Console.WriteLine(sb);
                    break;
                }
            }
        }
    }
}
