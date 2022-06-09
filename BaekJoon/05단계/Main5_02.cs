using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._05단계
{
    internal class Main5_02
    {
        static void Main2(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int result = 0;
            for(int i = 1; i <=  count; i++)
            {
                if (Calc(i)) result++; 
            }

            Console.WriteLine(result);
        }

        static bool Calc(int number)
        {
            string str = number.ToString();
            if (str.Length <= 2) return true;

            for(int i = 1; i < str.Length - 1; i++)
            {
                if (int.Parse(str[i - 1].ToString()) - int.Parse(str[i].ToString()) != int.Parse(str[i].ToString()) - int.Parse(str[i + 1].ToString()))
                {
                    return false;
                }
            }

            return true;
        }

    }
}
