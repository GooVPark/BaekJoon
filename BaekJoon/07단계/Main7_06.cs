using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_06
    {
        static void Main6(string[] args)
        {
            int[,] rooms = new int[15, 15];

            for (int i = 0; i < 15; i++) rooms[0,i] = i;

            for(int x = 1; x <= 14; x++)
            {
                for(int y = 1; y <= 14; y++)
                {
                    rooms[x, y] = rooms[x - 1, y] + rooms[x, y - 1];
                }
            }

            int count = int.Parse(Console.ReadLine());
            int[] results = new int[count];
            for(int i = 0; i < count; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                results[i] = rooms[x, y];
            }

            foreach(int result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
