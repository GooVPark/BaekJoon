using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._08단계
{
    internal class Main8_05
    {
        static void Main5(string[] args)
        {
            StringBuilder result = new StringBuilder();

            while (true)
            {
                int start = int.Parse(Console.ReadLine());
                if (start == 0)
                {
                    Console.WriteLine(result.ToString());
                    break;
                }

                int end = start * 2;
                int count = 0;

                for (int i = start + 1; i <= end; i++)
                {
                    if (IsPrime(i)) count++;
                }

                result.Append(count + "\n");
            }
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
