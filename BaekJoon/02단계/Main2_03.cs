using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._02단계
{
    internal class Main2_03
    {
        static void Main03(string[] args)
        {
            string str = Console.ReadLine();

            int year = int.Parse(str);

            if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
