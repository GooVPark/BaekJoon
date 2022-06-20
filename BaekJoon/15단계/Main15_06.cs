using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._15단계
{
    internal class Main15_06
    {
        struct Vector { public int x; public int y; }

        static Vector[] vectors = new Vector[81];
        static int[,] board = new int[9, 9];
        static StringBuilder sb = new StringBuilder();
        static int count = 0;

        static void Main6(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            for(int i = 0; i < 9; i++)
            {
                string[] input = sr.ReadLine().Split();
                for (int j = 0; j < 9; j++)
                {
                    board[i, j] = int.Parse(input[j]);
                    if (board[i, j] == 0)
                    {
                        vectors[count].x = i;
                        vectors[count].y = j;
                        count++;
                    }
                }
            }

            DFS(0);
        }

        static bool DFS(int depth)
        {
            if(depth == count)
            {
                for(int i = 0; i < 9; i++)
                {
                    for(int j = 0; j < 9; j++)
                    {
                        sb.Append(board[i, j] + " ");
                    }
                    sb.AppendLine();
                }

                Console.WriteLine(sb);
                return true;
            }

            int x = vectors[depth].x;
            int y = vectors[depth].y;
            
            for (int i = 1; i <= 9; i++)
            {
                if(CheckSquare(x / 3, y / 3, i) && CheckCross(x, y, i))
                {
                    board[x, y] = i;
                    if (!DFS(depth + 1)) board[x, y] = 0;
                    else return true;
                }
            }

            return false;
        }

        static bool CheckSquare(int x, int y, int value)
        {
            for(int i = x * 3; i < x * 3 + 3; i++)
            {
                for(int j = y * 3; j < y * 3 + 3; j++)
                {
                    if (board[i, j] == value) return false;
                }
            }
            return true;
        }

        static bool CheckCross(int x, int y, int value)
        {
            for (int i = 0; i < 9; i++) if (board[x, i] == value) return false;
            for (int i = 0; i < 9; i++) if (board[i, y] == value) return false;
            return true;
        }
    }
}
