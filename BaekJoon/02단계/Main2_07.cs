using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._02단계
{
    internal class Main2_07
    {
        static void Main07(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int num1 = int.Parse(str[0]);
            int num2 = int.Parse(str[1]);
            int num3 = int.Parse(str[2]);

            if(num1 == num2 && num2 == num3)
            {
                Console.WriteLine(10000 + num1 * 1000);
            }
            else if(num1 == num2)
            {
                Console.WriteLine(1000 + num1 * 100);
            }
            else if(num2 == num3)
            {
                Console.WriteLine(1000 + num2 * 100);
            }
            else if(num3 == num1)
            {
                Console.WriteLine(1000 + num3 * 100);
            }
            else
            {
                num1 = num1 > num2 ? num1 : num2;
                num1 = num3 > num1 ? num3 : num1;
                Console.WriteLine(num1 * 100);
            }
        }
    }
}
