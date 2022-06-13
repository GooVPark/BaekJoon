using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._11단계
{
    internal class Main11_07
    {
        public class Point : IComparable<Point>
        {
            public int x;
            public int y;

            public Point(string input)
            {
                string[] inputs = input.Split();
                x = int.Parse(inputs[0]);
                y = int.Parse(inputs[1]);
            }

            public void Print(StringBuilder sb)
            {
                sb.Append($"{x} {y}").AppendLine();
            }

            public int CompareTo(Point? other)
            {
                if (y == other.y) return x.CompareTo(other.x);
                return y.CompareTo(other.y);
            }
        }

        static void Main7(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int count = int.Parse(sr.ReadLine());

            Point[] points = new Point[count];

            for (int i = 0; i < count; i++) points[i] = new Point(sr.ReadLine());
            sr.Close();

            Array.Sort(points);

            for (int i = 0; i < points.Length; i++) points[i].Print(sb);

            Console.WriteLine(sb.ToString());
        }
    }
}
