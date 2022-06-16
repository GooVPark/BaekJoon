using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._14단계
{
    internal class Main14_07
    {
        static void Main7(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            if(n == k || n == 0 || k == 0)
            {
                Console.WriteLine("1");
                return;
            }
            int bc = Facorial(n) / (Facorial(k) * Facorial(n - k));
            Console.WriteLine(bc);
        }

        static int Facorial(int n)
        {
            if (n == 1) return 1;
            else return n * Facorial(n - 1);
        }
    }
}
