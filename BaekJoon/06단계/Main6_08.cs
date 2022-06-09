using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_08
    {
        static void Main8(string[] args)
        {
            int[] times = new int[9];
            int baseTime = 2;
            for(int i = 0; i < times.Length; i++)
            {
                times[i] = baseTime++;
            }

            string str = Console.ReadLine();
            int totalTime = 0;
            for(int i = 0; i < str.Length; i++)
            {
                totalTime += times[GetNumber(str[i]) - 1];
            }

            Console.WriteLine(totalTime);
        }

        static int GetNumber(char c)
        {
            switch(c)
            {
                case 'A':
                case 'B':
                case 'C':
                    return 2;
                case 'D':
                case 'E':
                case 'F':
                    return 3;
                case 'G':
                case 'H':
                case 'I':
                    return 4;
                case 'J':
                case 'K':
                case 'L':
                    return 5;
                case 'M':
                case 'N':
                case 'O':
                    return 6;
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                    return 7;
                case 'T':
                case 'U':
                case 'V':
                    return 8;
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    return 9;
                default:
                    return 0;
            }
        }
    }
}
