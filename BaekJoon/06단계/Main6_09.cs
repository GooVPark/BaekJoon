using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_09
    {
        static void Main9(string[] args)
        {
            string[] spliter = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            string str = Console.ReadLine();

            int totalCounts = 0;

            for(int i = 0; i < spliter.Length; i++)
            {
                int splitLength = 0;
                string[] strs = str.Split(spliter[i], StringSplitOptions.RemoveEmptyEntries);
                
                foreach (string str2 in strs)
                {
                    splitLength += str2.Length;
                }

                splitLength = (str.Length - splitLength) / spliter[i].Length;
                totalCounts += splitLength;
            }

            Console.WriteLine(str.Length - totalCounts);
        }
    }
}
