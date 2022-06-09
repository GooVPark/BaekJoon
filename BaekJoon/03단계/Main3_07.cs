using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_07
    {
        static void Main7(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            StringBuilder stringBuilder = new StringBuilder();

            for(int i = 1; i < count + 1; i++)
            {
                string[] numbers = Console.ReadLine().Split();

                int num1 = int.Parse(numbers[0]);
                int num2 = int.Parse(numbers[1]);

                stringBuilder.Append($"Case #{i}: {num1 + num2}\n");
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
