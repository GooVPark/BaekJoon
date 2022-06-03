using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._02단계
{
    internal class Main2_02
    {
        static void Main02(string[] args)
        {
            string num = Console.ReadLine();
            int score = int.Parse(num);

            if (score >= 90) Console.WriteLine("A");
            else if (score >= 80) Console.WriteLine("B");
            else if (score >= 70) Console.WriteLine("C");
            else if (score >= 60) Console.WriteLine("D");
            else Console.WriteLine("F");
        }
    }
}
