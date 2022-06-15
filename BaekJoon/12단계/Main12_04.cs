using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._12단계
{
    internal class Main12_04
    {
        static void Main4(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            Dictionary<int, int> map = new Dictionary<int, int>();

            int count = int.Parse(sr.ReadLine());
            string[] nums1 = sr.ReadLine().Split();
            for(int i = 0; i < count; i++)
            {
                int number = int.Parse(nums1[i]);
                if (map.ContainsKey(number)) map[number]++;
                else map.Add(number, 1);
            }

            count = int.Parse(sr.ReadLine());
            string[] nums2 = sr.ReadLine().Split();
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(nums2[i]);
                if (map.ContainsKey(number)) sb.Append($"{map[number]} ");
                else sb.Append("0 ");
            }

            Console.WriteLine(sb);
        }
    }
}
