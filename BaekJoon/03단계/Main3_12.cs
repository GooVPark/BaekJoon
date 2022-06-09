using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_12
    {
        static void Main12(string[] args)
        {
            while(true)
            {
                string input = Console.ReadLine();
                if (input == null) break;

                Console.WriteLine($"{int.Parse(input.Split()[0]) + int.Parse(input.Split()[1])}");
            }
        }
    }
}
