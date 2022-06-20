using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_10
    {
        static void Main10(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int testCaseCount = int.Parse(sr.ReadLine());

            Dictionary<string, int> closet = new Dictionary<string, int>();

            for (int test = 0; test < testCaseCount; test++)
            {
                int count = int.Parse(sr.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    string input = sr.ReadLine().Split()[1];

                    if (closet.ContainsKey(input)) closet[input]++;
                    else closet.Add(input, 2);
                }
                int total = 1;

                foreach (string key in closet.Keys)
                {
                    total *= closet[key];
                }

                Console.WriteLine(total - 1);
                closet.Clear();
            }
        }
    }
}
