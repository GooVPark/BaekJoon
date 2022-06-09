using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_11
    {
        static void Main11(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while(true)
            {
                string[] numbers = Console.ReadLine().Split();
                int num1 = int.Parse(numbers[0]);  
                int num2 = int.Parse(numbers[1]);

                if (numbers[0] == "\0")
                {
                    Console.WriteLine(sb.ToString());
                    break;
                }
                else
                {
                    sb.Append(num1 + num2 + "\n");
                }
            }
        }
    }
}
