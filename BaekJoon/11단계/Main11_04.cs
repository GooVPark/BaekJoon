using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaekJoon._11단계
{
    internal class Main11_04
    {
        struct KeyValue
        {
            public int key;
            public int value;
        }
        static void Main4(string[] args)
        {
        StreamReader reader = new StreamReader(Console.OpenStandardInput());

            int count = int.Parse(reader.ReadLine());
            int[] array = new int[count];
            KeyValue[] counting = new KeyValue[8001];
            int sum = 0;

            for(int i = 0; i < count; i++)
            {
                int number = int.Parse(reader.ReadLine());
                sum += number;
                array[i] = number;
                counting[number + 4000].key = number;
                counting[number + 4000].value++;
            }

            Array.Sort(array);
            Array.Sort(counting, (x, y) => x.value.CompareTo(y.value));

            int max = counting[counting.Length - 1].value;
            if (counting[counting.Length - 2].value == max)
            {
                Array.Reverse(counting);
                int keyCount = 0;
                for(int i = 0; i < counting.Length; i++) if (max == counting[i].value) keyCount++;

                int[] keys = new int[keyCount];
                for (int i = 0; i < keyCount; i++) keys[i] = counting[i].key;

                Array.Sort(keys);
                max = keys[1];
            }
            else max = counting[counting.Length - 1].key;

            double avg = Math.Round((double)sum / count);
            if (avg == -0) avg = 0;
            Console.WriteLine(avg);
            Console.WriteLine(Math.Round((double)array[array.Length/2]));
            Console.WriteLine(max);
            Console.WriteLine(array[array.Length - 1] - array[0]);
        }
    }
}
