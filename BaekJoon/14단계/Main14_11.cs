using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_11
    {
        static void Main11(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = 0;

            for(int i = 5; i <= number; i *= 5) result += (number / i);
           
            Console.WriteLine(result);
        }
    }
}
