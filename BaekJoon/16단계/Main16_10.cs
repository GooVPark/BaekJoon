using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_10
    {
        static void Main10(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n+1, 10];

            for (int i = 1; i < 10; i++) arr[1, i] = 1;

            for(int i = 2; i <= n; i++ )
            {
                arr[i, 0] = arr[i - 1, 1] % 1000000000;
                arr[i, 9] = arr[i - 1, 8] % 1000000000;
                for(int j = 1; j <= 8; j++)
                {
                    arr[i, j] = (arr[i - 1, j - 1] + arr[i - 1, j + 1]) % 1000000000;
                }
            }

            int sum = 0;
            for(int i = 0; i < 10; i++)
            {
                sum = (sum + arr[n, i]) % 1000000000;
            }

            Console.WriteLine(sum);
        }
    }
}
