using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._12단계
{
    internal class Main12_07
    {
        static void Main7(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, bool> map = new Dictionary<string, bool>();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j + i <= input.Length; j++)
                {                    
                    string temp = input.Substring(i, j);
                
                    if (!map.ContainsKey(temp))
                    {
                        map.Add(temp, true);
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
