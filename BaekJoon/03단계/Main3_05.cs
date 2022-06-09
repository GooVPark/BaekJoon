using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_05
    {
        static void Main5(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for(int i = 1; i < number + 1; i++)
            {
                sb.Append(i + "\n");
            }

            Console.WriteLine(sb.ToString());  
        }
    }
}
