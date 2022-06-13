using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._11단계
{
    internal class Main11_08
    {
        public class Word
        {
            public string word;
            public char[] alphabets;
            public int length;

            public Word(string input)
            {
                word = input;
                alphabets = new char[input.Length];
                alphabets = input.ToCharArray();
                length = alphabets.Length;
            }

            public void Print(StringBuilder sb)
            {
                string word = new string(alphabets);
                sb.Append(word).AppendLine();
            }

            public int CompareTo(Word other)
            {
                int index = 0;

                while(index < length && index < other.length)
                {
                    if (alphabets[index] > other.alphabets[index])
                    {
                        return 1;
                    }
                    else if (alphabets[index] < other.alphabets[index])
                    {
                        return -1;
                    }
                    else
                    {
                        index++;
                    }
                }

                if (length > other.length) return 1;
                else return -1;
            }
        }

        static bool FindWordInList(List<Word> list, string input)
        {
            foreach(Word word in list)
            {
                if(word.word == input) return true;
            }
            return false;
        }
        static void Main8(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            Dictionary<int, List<Word>> words = new Dictionary<int, List<Word>>();
            
            for(int i = 0; i < 51; i++) words.Add(i, new List<Word>());

            int count = int.Parse(sr.ReadLine());

            for(int i = 0; i < count; i++)
            {
                string word = sr.ReadLine();
                int key = word.Length;

                if (words.ContainsKey(key) && !FindWordInList(words[key], word))
                {
                    words[key].Add(new Word(word));
                }
            }

            List<Word> list = new List<Word>();

            for(int i = 0; i < words.Count; i++)
            {
                if (words[i].Count > 0)
                {
                    MergeSort(words[i], 0, words[i].Count - 1);
                    list.AddRange(words[i]);
                }
            }

            for (int i = 0; i < list.Count; i++) list[i].Print(sb);
            Console.WriteLine(sb);
        }

        public static void MergeSort(List<Word> list, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                MergeSort(list, start, mid);
                MergeSort(list, mid + 1, end);
                Merge(list, start, mid, end);
            }
        }

        public static void Merge(List<Word> list, int start, int mid, int end)
        {
            Word[] leftArray = new Word[mid - start + 1];
            Word[] rightArray = new Word[end - mid];

            for (int i = 0; i + start <= mid; i++) leftArray[i] = list[start + i];
            for (int i = 0; mid + i + 1 <= end; i++) rightArray[i] = list[mid + i + 1];


            int leftIndex = 0;
            int rightIndex = 0;
            int index = start;

            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) < 0)
                {
                    list[index] = leftArray[leftIndex];
                    leftIndex++;
                }
                else if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) > 0)
                {
                    list[index] = rightArray[rightIndex];
                    rightIndex++;
                }

                index++;
            }

            while (leftArray.Length > leftIndex)
            {
                list[index] = leftArray[leftIndex];
                index++;
                leftIndex++;
            }

            while (rightArray.Length > rightIndex)
            {
                list[index] = rightArray[rightIndex];
                index++;
                rightIndex++;
            }
        }
    }
}
