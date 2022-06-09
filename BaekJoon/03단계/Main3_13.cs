using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_13
    {
        static void Main13(string[] args)
        {
            string input = Console.ReadLine();
            
            string origin = input;
            int count = 0;
            while (true)
            {
                if (input.Length == 1) input = "0" + input;
                string sum = (int.Parse(input[0].ToString()) + int.Parse(input[1].ToString())).ToString();
                if (sum.Length == 1) sum = "0" + sum;
                string num = input[1].ToString();

                input = num + sum[1].ToString();

                count++;
                if(int.Parse(origin) == int.Parse(input))
                {
                    Console.WriteLine(count);
                    break;
                }
            }
        }
    }
}
