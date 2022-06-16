using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_06
    {
        static void Main6(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            int[] numbers = new int[count];
            for (int i = 0; i < count; i++) numbers[i] = int.Parse(input[i]);

            int numerator = 1;
            int denominator = 1;

            for (int i = 1; i < count; i++)
            {
                numerator *= (numbers[i - 1]);
                denominator *= (numbers[i]);

                int gcd = GCD(numerator, denominator);

                numerator /= gcd;
                denominator /= gcd;

                Console.WriteLine($"{numerator}/{denominator}");
            }
        }
        static int GCD(int num1, int num2)
        {
            if(num2 > num1)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            return num1 % num2 == 0 ? num2 : GCD(num2, num1 % num2);
        }
    }
}
