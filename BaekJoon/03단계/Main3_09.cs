using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_09
    {
        static void Main9(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                for(int j = count - i -1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
