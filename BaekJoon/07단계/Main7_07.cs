using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_07
    {
        static void Main7(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int min = 1000000;

            for(int i = 0; i <= number / 5; i++)
            {
                for(int j = 0; j <= number / 3; j++)
                {
                    if((i * 5) + (j * 3) == number)
                    {
                        Console.WriteLine($"5: {i}   3: {j}");
                        int sum = i + j;
                        if (sum < min) min = sum;
                    }
                }
            }

            if (min == 1000000) Console.WriteLine(-1);
            else Console.WriteLine(min);
        }
    }
}
