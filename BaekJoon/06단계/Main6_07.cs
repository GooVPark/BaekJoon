using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_07
    {
        static void Main7(string[] args)
        {
            string[] strs = Console.ReadLine().Split();
            int num1 = int.Parse(Reverse(strs[0]));
            int num2 = int.Parse(Reverse(strs[1]));

            Console.WriteLine(num1 > num2 ? num1 : num2);
        }

        static string Reverse(string str)
        {
            string tempStr = String.Empty;

            for(int i = str.Length - 1; i >= 0; i--)
            {
                tempStr += str[i];
            }

            return tempStr;
        }
    }
}
