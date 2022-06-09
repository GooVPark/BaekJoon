using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_05
    {
        static void Main5(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] results = new string[count];
            for (int i = 0; i < count; i++)
            {
                string[] strs = Console.ReadLine().Split();

                int H = int.Parse(strs[0]);
                int W = int.Parse(strs[1]);
                int N = int.Parse(strs[2]);

                int floor = 0;
                int room = 0;

                if (N <= H)
                {
                    floor = N;
                    room = 1;
                }
                else if(N % H == 0 && N > H)
                {
                    floor = H;
                    room = N / H;
                }
                else
                { 
                    floor = N % H;
                    room = N / H + 1;
                }

                //Console.WriteLine(floor);
                //Console.WriteLine(room);
                
                results[i] = floor.ToString() + room.ToString().PadLeft(2, '0');
            }

            foreach(string str in results)
            {
                Console.WriteLine(str);
            }
        }
    }
}
