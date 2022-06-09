using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._08단계
{
    internal class Main8_02
    {
        static void Main2(string[] args)
        {
            int start = int.Parse(Console.ReadLine()); 
            int end = int.Parse(Console.ReadLine());

            int primeCount = 0;
            int sum = 0;
            int min = 1000000;

            for(int i = start; i <= end; i++)
            {
                if(IsPrime(i))
                {
                    sum += i;
                    if (min > i) min = i;
                    primeCount++;
                }
            }

            if (primeCount == 0) Console.WriteLine(-1);
            else Console.WriteLine($"{sum}\n{min}");
        }

        public static bool IsPrime(int num)
        {
            if (num == 1) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
