using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_01
    {
        static void Main1(string[] args)
        {
            string[] strs = Console.ReadLine().Split();
            int fixedCost = int.Parse(strs[0]);
            int variableCost = int.Parse(strs[1]);
            int cost = int.Parse(strs[2]);
            if(cost <= variableCost)
            {
                Console.WriteLine(-1);
                return;
            }

            int count = fixedCost / (cost - variableCost);

            Console.WriteLine(count + 1);
        }
    }
}
