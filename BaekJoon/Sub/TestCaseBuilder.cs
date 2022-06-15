using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaekJoon.Sub
{
    internal class TestCaseBuilder
    {
        static void Maint(string[] args)
        {
            string path = @"C:\Users\1302\Desktop\TestCase.txt";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            sb.Append("1000000\n");
            for (int i = 0; i < 1000000; i++)
            {
                sb.Append(random.Next(-1000000000, 1000000000) + " ");
            }

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            StreamWriter writer;
            writer = File.AppendText(path);
            writer.Write(sb.ToString());
            writer.Close();


        }
    }
}
