using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_03
    {
        static void Main03(string[] args)
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);
            int sum = 0;

            for(int i = 1; i < num + 1; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
