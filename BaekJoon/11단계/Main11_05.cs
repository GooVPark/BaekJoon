using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._11단계
{
    internal class Main11_05
    {
        static void Main5(string[] args)
        {
            string str = Console.ReadLine();
            char[] charArray = new char[str.Length];
            charArray = str.ToCharArray();

            Array.Sort(charArray);
            Array.Reverse(charArray);

            for(int i = 0; i < charArray.Length; i++) Console.Write(charArray[i]);
        }
    }
}
