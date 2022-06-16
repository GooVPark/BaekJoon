using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_04
    {
        static void Main4(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                int num1 = int.Parse(input[0]);
                int num2 = int.Parse(input[1]);

                if(num1 < num2)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp;
                }

                int factor = GCD(num1, num2);
                sb.AppendLine((num1 * num2 / factor).ToString());
            }

            Console.WriteLine(sb);
        }


        static int GCD(int a, int b)
        {
            return a % b == 0 ? b : GCD(b, a % b);
        }
    }
}
