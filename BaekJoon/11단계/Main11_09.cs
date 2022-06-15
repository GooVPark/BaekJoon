using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._11단계
{
    public class Account
    {
        public int date;
        public int age;
        public string name;

        public Account(int date, int age, string name)
        {
            this.date = date;
            this.age = age;
            this.name = name;
        }

        public int ComapreTo(Account other)
        {
            if (this.age > other.age) return -1;
            else if(this.age < other.age) return 1;
            else
            {
                if (this.date > other.date) return -1;
                else if (this.date < other.date) return 1;
                else return 0;
            }
        }

        public void Print(StringBuilder sb)
        {
            sb.AppendLine($"{age} {name}");
        }
    }
    internal class Main11_09
    {
        static void Main9(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(sr.ReadLine());
            List<Account > list = new List<Account>();

            for(int i = 0; i < count; i++)
            {
                string[] input = sr.ReadLine().Split();
                list.Add(new Account(i, int.Parse(input[0]), input[1]));
            }

            QuickSort(list, 0, list.Count - 1);
            for (int i = 0; i < list.Count; i++) list[i].Print(sb);
            Console.WriteLine(sb);
            
        }

        public static  void QuickSort(List<Account> list, int left, int right)
        {
            if (left >= right) return;

            Account temp;
            Account pivot = list[(left + right) / 2];
            int i = left, j = right;
            while (i < j)
            {
                while (list[i].ComapreTo(pivot) > 0) i++;
                while (list[j].ComapreTo(pivot) < 0) j--;              

                if (i < j)
                {
                    if (list[i] == list[j]) break;

                    temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }

            QuickSort(list, left, j - 1);   
            QuickSort(list, j + 1, right);
        }
    }

}
