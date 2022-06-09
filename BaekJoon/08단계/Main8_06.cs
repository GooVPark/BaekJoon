using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._08단계
{
    internal class Main8_06
    {
        static void Main6(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            StringBuilder results = new StringBuilder();

            for(int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int down = (int)Math.Floor((double)((double)number / 2));
                int up = (int)Math.Ceiling((double)((double)number / 2));

                while(!IsPrime(up) || !IsPrime(down))
                {
                    up++;
                    down--;
                }

                results.Append($"{down} {up}\n");
            }

            Console.WriteLine(results.ToString());
        }

        public static bool IsPrime(int num)
        {
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

    }
}
