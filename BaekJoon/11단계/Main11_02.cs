using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._11단계
{
    internal class Main11_02
    {
        static void Main2(string[] args)
        {
            StringBuilder result = new StringBuilder();
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];

            for(int i = 0; i < count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            
            foreach (int n in array) result.Append(n.ToString() + "\n");
            Console.WriteLine(result);
        }

        

        public static void MergeSort(int[] array, int start, int end)
        {
            if(start < end)
            {
                int mid = (start + end) / 2;
                MergeSort(array, start, mid);
                MergeSort(array, mid + 1, array.Length - 1);
                Merge(array, 0, mid, array.Length - 1);
            }
        }

        public static void Merge(int[] array, int start, int mid, int end)
        {
            int[] leftArray = new int[mid];
            int[] rightArray = new int[end - mid + 1];

            for (int i = 0; i + start < mid; i++)
            {
                leftArray[i] = array[start + i];
            }
            for(int i = 0; mid + i <= end; i++)
            {
                rightArray[i] = array[mid + i];
            }

            int leftIndex = 0;
            int rightIndex = 0;
            int index = 0;

            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex] < rightArray[rightIndex])
                {
                    array[index] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[index] = rightArray[rightIndex];
                    rightIndex++;
                }

                index++;
            }

            while(leftArray.Length > leftIndex)
            {
                array[index] = leftArray[leftIndex];
                index++;
                leftIndex++;
            }

            while(rightArray.Length > rightIndex)
            {
                array[index] = rightArray[rightIndex];
                index++;
                rightIndex++;
            }
        }
    }
}
