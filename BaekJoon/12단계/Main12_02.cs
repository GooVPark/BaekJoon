using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._12단계
{
    internal class Main12_02
    {
        static void Main2(string[] args)
        {
            Dictionary<string, bool> map = new Dictionary<string, bool>();
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            string[] counts = sr.ReadLine().Split();

            int nCount = int.Parse(counts[0]);
            int mCount = int.Parse(counts[1]);

            int count = 0;

            for (int i = 0; i < nCount; i++) map.Add(sr.ReadLine(), false);
            for (int i = 0; i < mCount; i++)
            {
                string key = sr.ReadLine();
                if (map.ContainsKey(key))
                {
                    map[key] = true;
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
