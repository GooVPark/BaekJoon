using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_10
    {
        static void Main10(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int count = int.Parse(inputs[0]);
            int number = int.Parse(inputs[1]);

            string[] numbers = Console.ReadLine().Split();

            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < count; i++)
            {
                int num = int.Parse(numbers[i]);
                if(num < number) sb.Append(num + " ");
            }

            Console.WriteLine(sb.ToString());   
        }
    }
}
