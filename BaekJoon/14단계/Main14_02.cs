using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_02
    {
        static void Main2(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            int result = 0;

            for (int i = 0; i < count; i++)
            {
                int factor = int.Parse(input[i]);
                if (factor > max) max = factor;
                if (factor < min) min = factor;
            }

            result = min * max;
            
            Console.WriteLine(result);
        }
    }
}
