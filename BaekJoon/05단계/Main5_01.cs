using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main5_01
    {
        static void Main1(string[] args)
        {
            int[] numbers = new int[10001];

            for(int i = 0; i < numbers.Length; i++)
            {
                int index = GetNumber(i);
                if(index <= 10000) numbers[index] = i;
            }

            for(int i = 1; i < numbers.Length; i++) 
            {
                if (numbers[i] == 0) Console.WriteLine(i);
            }
        }

        static int GetNumber(int number)
        {
            int result = number;

            string str = number.ToString();
            for(int i = 0; i < str.Length; i++)
            {
                result += int.Parse(str[i].ToString());
            }
            return result;
        }
    }
}
