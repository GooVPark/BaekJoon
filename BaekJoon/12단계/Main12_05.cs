using System.Collections.Generic;
using System.Text;

namespace BaekJoon._12단계
{
    internal class Main12_05
    {
        static void Main5(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            string[] counts = sr.ReadLine().Split();
            int nCount = int.Parse(counts[0]);
            int mCount = int.Parse(counts[1]);

            Dictionary<string, bool> map = new Dictionary<string, bool>();
            List<string> list = new List<string>();
            
            for (int i = 0; i < nCount; i++) map.Add(sr.ReadLine(), true);
            for (int i = 0; i < mCount; i++)
            {
                string s = sr.ReadLine();
                if (map.ContainsKey(s))
                {
                    list.Add(s);
                }
            }

            list.Sort();

            for (int i = 0; i < list.Count; i++) sb.AppendLine(list[i]);

            Console.WriteLine(list.Count);
            Console.WriteLine(sb);
        }
    }
}
