using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._13단계
{
    internal class Main13_02
    {
        static void Main2(string[] args)
        {
            Dictionary<string, int> xPoints = new Dictionary<string, int>();
            Dictionary<string, int> yPoints = new Dictionary<string, int>();

            string[] inputs = new string[3];

            for(int i = 0; i < 3; i++)
            {
                inputs[i] = Console.ReadLine();
                string x = inputs[i].Split()[0];
                string y = inputs[i].Split()[1];

                if (xPoints.ContainsKey(x)) xPoints[x]++;
                else xPoints.Add(x, 1);

                if (yPoints.ContainsKey(y)) yPoints[y]++;
                else yPoints.Add(y, 1);
            }

            string xPos = string.Empty;
            string yPos = string.Empty;

            foreach(string key in xPoints.Keys)
            {
                if (xPoints[key] == 1)
                {
                    xPos = key;
                    break;
                }
            }
            foreach (string key in yPoints.Keys)
            {
                if (yPoints[key] == 1)
                {
                    yPos = key;
                    break;
                }
            }

            Console.WriteLine($"{xPos} {yPos}");

        }
    }
}
