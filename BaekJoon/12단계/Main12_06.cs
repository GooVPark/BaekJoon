using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._12단계
{
    internal class Main12_06
    {
        static void Main6(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] counts = sr.ReadLine().Split();
            int aCount = int.Parse(counts[0]);
            int bCount = int.Parse(counts[1]);

            int totalCount = aCount + bCount;

            List<string> aSet = sr.ReadLine().Split().ToList();
            List<string> bSet = sr.ReadLine().Split().ToList();

            var intersection = aSet.Intersect(bSet);

            int intersectionCount = intersection.Count();

            Console.WriteLine(totalCount - (intersectionCount * 2));
        }
    }
}
