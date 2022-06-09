using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_05
    {
        static void Main5(string[] args)
        {
            string str = Console.ReadLine().ToUpper();
            int[] alphabet = new int[26];
            
            for(int i = 0; i < str.Length; i++)
            {
                alphabet[str[i] - 'A']++;
            }

            int max = -1;
            int maxIndex = 0;

            for(int i = 0; i < alphabet.Length; i++)
            {
                if (max < alphabet[i])
                {
                    max = alphabet[i];
                    maxIndex = i;
                }
            }

            for(int i = 0; i < alphabet.Length; i++)
            {
                for(int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[i] != 0 && alphabet[j] != 0 && alphabet[i] == alphabet[j] && i != j && alphabet[i] == max)
                    {
                        Console.Write("?");
                        return;
                    }
                }
            }
            Console.Write((char)(maxIndex + 'A'));
        }
    }
}
