using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._10단계
{
    internal class Main10_05
    {
        static void Main5(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string doom = "666";

            int number = 0;
            int roofCount = 0;
            while (roofCount != count)
            {
                number++;
                if(number.ToString().Contains("666")) roofCount++;
            }

            Console.WriteLine(number);
        }
    }
}
