using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._01단계
{
    internal class Main1_13
    {
        static void Main13(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int num1 = int.Parse(str1);
            int num2 = int.Parse(str2);

            Console.WriteLine(num1 * int.Parse(str2[2].ToString()));
            Console.WriteLine(num1 * int.Parse(str2[1].ToString()));
            Console.WriteLine(num1 * int.Parse(str2[0].ToString()));
            Console.WriteLine(num1 * num2);
        }
    }
}
