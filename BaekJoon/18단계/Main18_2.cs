using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._18단계
{
    class Time : IComparable
    {
        public int start;
        public int end;

        public Time(string[] input)
        {
            start = int.Parse(input[0]);
            end = int.Parse(input[1]);
        }

        public int CompareTo(object? obj)
        {
            if (start > (obj as Time).start) return 1;
            else
            {
                if(start == (obj as Time).start)
                {
                    if (end > (obj as Time).end) return 1;
                    else return -1;
                }
                return -1;
            }
        }
    }
    internal class Main18_2
    {
        static int N;
        static Time[] times;
        static int latest;
        static int count = 0;
        static int max = 0;
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            N = int.Parse(sr.ReadLine());
            times = new Time[N];

            for(int i = 0; i < N; i++)
            {
                times[i] = new Time(sr.ReadLine().Split());
            }

            Array.Sort(times);

            for(int i = 0; i < times.Length; i++)
            {

            }
        }

    }
}
