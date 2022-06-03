using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_01
    {
        static void Main01(string[] args)
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);

            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
    }
}
