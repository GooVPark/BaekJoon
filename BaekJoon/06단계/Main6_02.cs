using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_02
    {
        static void Main2(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            
            int total = 0;

            for(int i = 0; i < length; i++)
            {
                total += int.Parse(number[i].ToString());
            }

            Console.WriteLine(total);
        }
    }
}
