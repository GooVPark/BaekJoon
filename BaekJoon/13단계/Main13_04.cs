using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._13단계
{
    internal class Main13_04
    {
        static void Main4(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int totalCount = 0;

            int[] direction = new int[6];
            int[] length = new int[6];

            int x = 0;
            int y = 0;

            for(int i = 0; i < 6; i++)
            {
                string[] input = Console.ReadLine().Split();

                direction[i] = int.Parse(input[0]);
                length[i] = int.Parse(input[1]);

                if (direction[i] == 1 || direction[i] == 2) if (x < length[i]) x = length[i];
                if (direction[i] == 3 || direction[i] == 4) if (y < length[i]) y = length[i];
            }
            int index = 3;
            while (true)
            {
                if (direction[index % 6] == direction[(index - 2) % 6] && direction[(index - 1) % 6] == direction[(index - 3) % 6])
                {
                    totalCount = ((x * y) - (length[(index - 1) % 6] * length[(index - 2) % 6])) * count;
                    break;
                }
                index++;
            }

            Console.WriteLine(totalCount);
        }
    }
}
