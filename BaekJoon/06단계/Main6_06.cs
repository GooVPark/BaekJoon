using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_06
    {
        static void Main6(string[] args)
        {
            string[] strs = Console.ReadLine().Split();

            int count = 0;
            for(int i = 0; i < strs.Length; i++)
            {
                if (strs[i] == "")
                {
                    count++;
                }
            }
            Console.WriteLine(strs.Length - count);
        }
    }
}
