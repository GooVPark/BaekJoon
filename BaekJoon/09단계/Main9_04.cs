using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._09단계
{
    internal class Main9_04
    {
        static void Main4(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            char[,] map = new char[count, count];
            StringBuilder sb = new StringBuilder();
            
            for(int i = 0; i < count; i++)
            {
                for(int j = 0; j < count; j++)
                {
                    map[i, j] = '*';
                }
            }

            EraseStar(1, count, map);

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    sb.Append(map[i, j]);
                }
                sb.Append("\n");
            }

            Console.WriteLine(sb.ToString());

        }

        static void EraseStar(int count, int dest, char[,] map)
        {
            if (count == dest) return;
            else
            {
                for(int i = count; i <= dest; i += (count * 3))
                {
                    for (int j = count; j <= dest; j += (count* 3))
                    {
                        int startX = i;
                        int startY = j;
                        for (int x = startX; x < startX + count; x++)
                        {
                            for (int y = startY; y < startY + count; y++)
                            {
                                map[x, y] = ' ';
                            }
                        }
                    }
                }

                EraseStar(count *3, dest, map);
            }
        }
    }
}
