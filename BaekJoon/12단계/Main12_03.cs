using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._12단계
{
    internal class Main12_03
    {
        static void Main3(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder(); 
            string[] counts = sr.ReadLine().Split();

            int collectionCount = int.Parse(counts[0]);
            int count = int.Parse(counts[1]);

            Dictionary<string, int> stringIntPairs = new Dictionary<string, int>();
            Dictionary<string, string> intStringPairs = new Dictionary<string, string>();

            for(int i = 0; i < collectionCount; i++)
            {
                string pokemon = sr.ReadLine();
                stringIntPairs.Add(pokemon, i + 1);
                intStringPairs.Add((i + 1).ToString(), pokemon);
            }

            for(int i = 0; i < count; i++)
            {
                string input = sr.ReadLine();
                if (stringIntPairs.ContainsKey(input)) sb.AppendLine(stringIntPairs[input].ToString());
                else if (intStringPairs.ContainsKey(input)) sb.AppendLine(intStringPairs[input]);
            }

            Console.WriteLine(sb);
        }
    }
}
