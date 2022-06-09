using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_03
    {
        static void Main3(string[] args)
        {
            string str = Console.ReadLine();
            int[] slots = new int[26];
            for (int i = 0; i < slots.Length; i++) slots[i] = -1;

            for(int i = 0; i < str.Length; i++)
            {
                int slotNumber = str[i] - 97;
                if (slots[slotNumber] == -1) slots[slotNumber] = i;
            }

            for (int i = 0; i < slots.Length; i++) Console.Write(slots[i] +" ");
        }
    }
}
