using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BaekJoon._11단계
{
    internal class Main11_03
    {
        static void Main3(string[] args)
        {
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            writer.AutoFlush = true;
            StringBuilder result = new StringBuilder("");
            int count = int.Parse(reader.ReadLine());

            int[] array = new int[10001];

            for(int i = 0; i < count; i++)
            {
                array[int.Parse(reader.ReadLine())]++;
            }

            reader.Close();

            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i]; j++)
                {
                    result.Append(i).Append("\n");
                    
                    k++;

                    if (k == 500)
                    {
                        writer.Write(result.ToString());
                        result.Clear();
                        k = 0;
                    }
                }
            }

            writer.WriteLine(result.ToString());
        }
    }
}
