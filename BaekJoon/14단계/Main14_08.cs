using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_08
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            Console.WriteLine(C(n, k) % 10007);
        }

        static int C(int n, int k)
        {
            if (n == k || k == 0) return 1;
            Console.WriteLine($"{n}    {k}");
            return C(n - 1, k) + C(n - 1, k - 1);
        }
    }
}
