using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_03
    {
        static void Main3(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = 0;
            int line = 0;

            while(number > index)
            {
                line++;
                index += line;
            }

            int denominator = 0;
            int numerator = 0; 

            if (line % 2 == 0)
            {
                denominator = 1 + index - number;
                numerator = line - (index - number);
            }
            else
            {
                denominator = line - (index - number);
                numerator = 1 + index - number;
            }
         

            Console.WriteLine($"{numerator}/{denominator}");
        }
    }
}
