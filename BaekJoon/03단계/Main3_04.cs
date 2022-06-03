using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_04
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(str);

            for(int i = 0; i < count; i++)
            {
                string[] strs = Console.ReadLine().Split();
                int num1 = int.Parse(strs[0]);
                int num2 = int.Parse(strs[1]);

                Console.WriteLine(num1 + num2);
            }
        }
    }
}
