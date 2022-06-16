using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_05
    {
        static void Main5(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int count = int.Parse(sr.ReadLine());
            int[] inputs = new int[count];

            int min = Int32.MaxValue;
            int minIndex = 0;
            for(int i = 0; i < count; i++)
            {
                inputs[i] = int.Parse(sr.ReadLine());
            }

            int[] numbers = new int[count - 1];
            Array.Sort(inputs);

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = inputs[i + 1] - inputs[0];
            }

            int gcd = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                gcd = GCD(numbers[i], gcd);
            }

            for(int i = 2; i <= gcd; i++)
            {
                if (gcd % i == 0) sb.Append(i + " ");
            }
            Console.WriteLine(sb);
        }

        static int GCD(int num1, int num2)
        {
            return num1 % num2 == 0 ? num2 : GCD(num2, num1 % num2);
        }
    }
}
