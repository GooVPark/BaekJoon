using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_02
    {
        static void Main2(string[] args)
        {
            int dest = int.Parse(Console.ReadLine());

            if(dest == 1)
            {
                Console.WriteLine(1);
                return;
            }
            else if(dest < 8)
            {
                Console.WriteLine(2);
                return;
            }

            int center = 1;
            int count = 1;
            int min = 2;
            int max = 7;
            while (dest < min || dest > max)
            {
                min +=  (count * 6);
                max += ((count + 1 )* 6);
                count++;
            }

            Console.WriteLine(count + 1);
        }
    }
}
