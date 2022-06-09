using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._09단계
{
    internal class Main9_02
    {
        static void Main2(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(0, 1, number, 0));
        }

        static int Fibonacci(int n1, int n2, int dest, int count)
        {
            if (n2 == 0) return 0;
            if(count == dest - 1)
            {
                return  n2;
            }
            return Fibonacci(n2, n1 + n2, dest, ++count);
        }
    }
}
