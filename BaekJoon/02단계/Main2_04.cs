using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._02단계
{
    internal class Main2_04
    {
        static void Main04(string[] args)
        {
            string str1 = Console.ReadLine(); 
            string str2 = Console.ReadLine();

            int num1 = int.Parse(str1);
            int num2 = int.Parse(str2);

            if (num1 > 0 && num2 > 0) Console.WriteLine("1");
            else if (num1 < 0 && num2 > 0) Console.WriteLine("2");
            else if (num1 < 0 && num2 < 0) Console.WriteLine("3");
            else if (num1 > 0 && num2 < 0) Console.WriteLine("4");
        }
    }
}
