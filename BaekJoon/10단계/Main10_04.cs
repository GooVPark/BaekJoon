using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._10단계
{
    internal class Main10_04
    {
        static void Main4(string[] args)
        {
            string wBoard = "WBWBWBWBBWBWBWBWWBWBWBWBBWBWBWBWWBWBWBWBBWBWBWBWWBWBWBWBBWBWBWBW";
            string bBoard = "BWBWBWBWWBWBWBWBBWBWBWBWWBWBWBWBBWBWBWBWWBWBWBWBBWBWBWBWWBWBWBWB";
            string[] strs = Console.ReadLine().Split();
            int y = int.Parse(strs[0]);
            int x = int.Parse(strs[1]);

 
            string[] board = new string[y];
            for(int i = 0; i < y; i++)
            {
                string line = Console.ReadLine();
                board[i] = line;
            }

            int min = 65;
            for(int i = 0; i + 7 < x; i++)
            {
                for(int j = 0; j + 7 < y; j++)
                {
                    int compared = CompareString(GetComapreString(board, i, j), wBoard);
                    if (compared < min) min = compared;
                }
            }
            for(int i = 0; i + 7 < x; i++)
            {
                for(int j = 0; j + 7 < y; j++)
                {
                    int compared = CompareString(GetComapreString(board, i, j), bBoard);
                    if (compared < min) min = compared;
                }
            }
            Console.WriteLine(min);
        }

        static string GetComapreString(string[] board, int x, int y)
        {
            string str = string.Empty;

            for(int i = y; i < y + 8 ; i++)
            {
                str += board[i].Substring(x, 8);
            }

            return str;
        }

        static int CompareString(string str1, string str2)
        {
            int count = 0;
            //Console.WriteLine($"Target String: {str1}");
            //Console.WriteLine($"WBoard String: {str2}");
            for(int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i]) count++;
            } 
            //Console.WriteLine(count);
            return count;
        }
    }
}
