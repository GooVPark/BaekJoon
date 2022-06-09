using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._08단계
{
    internal class Main8_01
    {
        static void Main1(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] strs = Console.ReadLine().Split();

            int result = 0;

            for(int i = 0; i < count; i++)
            {
                if (IsPrime(int.Parse(strs[i]))) result++;
            }

            Console.WriteLine(result);
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
