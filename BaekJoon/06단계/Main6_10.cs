using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_10
    {
        static void Main10(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int result = 0;

            for(int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();
                char c = str[0];

                while (str.Length > 0)
                {
                    int index = str.IndexOf(c);
                    if (index == 0) str = str.Remove(index, 1);
                    else if (index == -1) c = str[0];
                    else
                    {
                        result++;
                        break;
                    }
                }
            }

            Console.WriteLine(count - result);
        }
    }
}
