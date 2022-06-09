using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_03
    {
        static void Main3(string[] args)
        {
            int num = 1;
            for(int i = 0; i < 3; i++)
            {
                num *= int.Parse(Console.ReadLine());
            }

            string str = num.ToString();
            int[] units = new int[10];

            for(int i = 0; i < str.Length; i++)
            {
                units[int.Parse(str[i].ToString())]++;
            }

            for(int i = 0; i < units.Length; i++)
            {
                Console.WriteLine(units[i]);
            }
        }
    }
}
