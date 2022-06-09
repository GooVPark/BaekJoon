using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_04
    {
        static void Main4(string[] args)
        {
            int[] arr = new int[42];
            int count = 0;

            for(int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int mod = num % 42;
                if (arr[mod] == 0) count++;
                arr[mod]++;
            }

            Console.WriteLine(count);
        }
    }
}
