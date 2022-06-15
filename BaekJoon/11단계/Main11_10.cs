using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._11단계
{
    internal class Main11_10
    {
        static void Main10(string[] args)
        {
            //StreamReader sr = new StreamReader(@"C:\Users\1302\Desktop\TestCase.txt");
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(sr.ReadLine());
            string[] nums = sr.ReadLine().Split();

            int[] numbers = new int[count];
            int[] origin = new int[count];

            //Console.WriteLine("Input..");
            for(int i = 0; i < count; i++)
            {
                origin[i] = int.Parse(nums[i]);
                numbers[i] = int.Parse(nums[i]);
                
            }

            //Console.WriteLine("Distinct");
            int[] sorted = Distinct(numbers);

            //Console.WriteLine("Sort");
            QuickSort(sorted, 0, sorted.Length - 1);

            //Console.WriteLine("Matching");
            for (int i = 0; i < origin.Length; i++) sb.Append(BinarySearch(sorted, origin[i], 0, sorted.Length - 1) + " ");
            //Console.WriteLine("Print");
            Console.WriteLine(sb);
        }

        public static int BinarySearch(int[] array, int value, int left, int right)
        {
            int index = (left + right) / 2;
            //Console.WriteLine($"Value: {value}, Pivot: {array[index]}, Left: {left}, Right: {right}");
            if (array[index] > value)
            {
                return BinarySearch(array, value, left, index - 1);
            }
            else if (array[index] < value)
            {

                return BinarySearch(array, value, index + 1, right);
            }
            else
            {
                return index;
            }
        }

        public static int[] Distinct(int[] array)
        {
            List<int> distinct = new List<int>();
            Dictionary<int, bool> map = new Dictionary<int, bool>();

            for(int i = 0; i < array.Length; i++)
            {
                if (!map.ContainsKey(array[i]))
                {
                    map[array[i]] = true;
                    distinct.Add(array[i]);
                }
            }
            
            return distinct.ToArray();
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)  return; 

            int temp;
            int pivot = array[(left + right) / 2];
            int i = left, j = right;
            while (i < j)
            {
                while (array[i] < pivot)  i++; 
                while (pivot < array[j])  j--; 

                if (i < j)
                {
                    if (array[i] == array[j])  break; 

                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            QuickSort(array, left, j - 1);
            QuickSort(array, j + 1, right);
        }
    }
}
