using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._11단계
{
    internal class Main11_01
    {
        static void Main1(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
