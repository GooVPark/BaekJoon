using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_01
    {
        static int fibCount1 = 0;
        static int fibCount2 = 0;
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] fArray = new int[n];
            Fib(n);
            Fibonacci(fArray, n);

            Console.WriteLine($"{fibCount1} {fibCount2}");
        }

        static int Fib(int n)
        {

            if (n == 1 || n == 2)
            {
                fibCount1++;
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        static int Fibonacci(int[] fArray, int n)
        {
            fArray[0] = 1;
            fArray[1] = 1;

            for(int i = 2; i < n; i++)
            {
                fibCount2++;
                fArray[i] = fArray[i - 1] + fArray[i - 2];
            }

            return fArray[n -1];
        }
    }
}
