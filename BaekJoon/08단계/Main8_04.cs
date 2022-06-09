using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._08단계
{
    internal class Main8_04
    {
        static void Main4(string[] args)
        {
            string[] strs = Console.ReadLine().Split();
            int start = int.Parse(strs[0]);
            int end = int.Parse(strs[1]);

            StringBuilder result = new StringBuilder();

            for(int i = start; i <= end; i++)
            {
                if (IsPrime(i)) result.Append(i + "\n"); 
            }

            Console.WriteLine(result.ToString());
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
