using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._09단계
{
    internal class Main9_01
    {
        static void Main1(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(number));
        }

        static int Factorial(int number)
        {
            if (number == 0) return 1;
            if(number == 1) return number;
            return number * Factorial(--number);
        }
    }
}
