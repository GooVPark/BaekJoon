using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._12단계
{
    internal class Main12_01
    {
        static void Main1(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int sgCount = int.Parse(sr.ReadLine());
            string[] sgStrs = sr.ReadLine().Split();
            bool[] sgNumbers = new bool[20000002];

            int myCount = int.Parse(sr.ReadLine());
            string[] myStrs = sr.ReadLine().Split();
            int[] myNumbers = new int[myCount];

            for (int i = 0; i < sgCount; i++) sgNumbers[int.Parse(sgStrs[i]) + 10000000] = true;
            for (int i = 0; i < myCount; i++)
            {
                int number = int.Parse(myStrs[i]);
                if (sgNumbers[number + 10000000]) myNumbers[i] = 1;
                else myNumbers[i] = 0;

                sb.Append(myNumbers[i] + " ");
            }

            Console.WriteLine(sb);
        }
    }
}
