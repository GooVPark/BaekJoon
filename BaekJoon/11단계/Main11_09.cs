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
            if (this.age > other.age) return 1;
            else if(this.age < other.age) return -1;
            else
            {
                if (this.date > other.date) return 1;
                else return -1;
            }
        }
    }
    internal class Main11_09
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int count = int.Parse(sr.ReadLine());
            List<Account > list = new List<Account>();

            for(int i = 0; i < list.Count; i++)
            {
                string[] input = sr.ReadLine().Split();
                list.Add(new Account(i, int.Parse(input[0]), input[1]));
            }
        }
    }
}
