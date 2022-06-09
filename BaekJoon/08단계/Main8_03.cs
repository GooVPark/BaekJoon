using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._08단계
{
    internal class Main8_03
    {
        static void Main3(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int divNumber = 2;

            while(number > 1)
            {
                if (number % divNumber == 0)
                {
                    Console.WriteLine(divNumber);
                    number /= divNumber;
                }
                else
                {
                    divNumber++;
                }
            }
        }
    }
}
