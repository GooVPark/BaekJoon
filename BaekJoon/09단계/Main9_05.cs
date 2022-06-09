using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._09단계
{
    internal class Main9_05
    {
        static void Main5(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            Console.WriteLine(Math.Pow(2, count) - 1);
            Hanoi(count, 1, 3, 2, result);
            Console.WriteLine(result.ToString());
        }

        public static void Hanoi(int count, int start, int end, int mid, StringBuilder result)
        {
            if (count == 1) Move(start, end, result);
            else
            {
                Hanoi(count - 1, start, mid, end, result);
                Move(start, end, result);
                Hanoi(count - 1, mid, end, start, result);
            }

        }

        public static void Move(int start, int end, StringBuilder result)
        {
            result.Append($"{start} {end}\n");
        }
    }
}
