using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_12
    {
        static void Main12(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]);

            long count2 = ZeroCount(n, 2) - (ZeroCount(n - k, 2) + ZeroCount(k, 2));
            long count5 = ZeroCount(n, 5) - (ZeroCount(n - k, 5) + ZeroCount(k, 5));

            Console.WriteLine(count2 < count5 ? count2 : count5);
        }

        static long ZeroCount(long n, long t)
        {
            long count = 0;
            for (long i = t; i <= n; i *= t) count += n / i;
            return count;
        }
    }
}
