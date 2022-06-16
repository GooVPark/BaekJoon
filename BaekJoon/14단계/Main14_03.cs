using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_03
    {
        static void Main3(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int num1 = int.Parse(input[0]);
            int num2 = int.Parse(input[1]);

            int factor = 0;
            int multiple = 0;

            if(num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            factor = GCD(num1, num2);
            multiple = num1 * num2 / factor;

            Console.WriteLine(factor);
            Console.WriteLine(multiple);
        }

        static int GCD(int num1, int num2)
        {
            return num1 % num2 == 0 ? num2 : GCD(num2, num1 % num2);
        }
    }
}
