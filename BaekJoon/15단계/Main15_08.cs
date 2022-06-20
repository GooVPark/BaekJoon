using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._15단계
{
    internal class Main15_08
    {
        static int[] members;
        static int count;
        static int[,] status;
        static int[] teamSpace = new int[2];
        static int min = int.MaxValue;
        static void Main8(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            count = int.Parse(sr.ReadLine());
            members = new int[count];
            teamSpace[0] = count / 2;
            teamSpace[1] = count / 2;
            status = new int[count, count];
            for(int i = 0; i < count; i++)
            {
                string[] input = sr.ReadLine().Split();
                for(int j = 0; j < count; j++)
                {
                    status[i, j] = int.Parse(input[j]);
                }
            }

            DFS(0);

            Console.WriteLine(min);
        }



        static void DFS(int depth)
        {
            if(depth == count)
            {
                int t1 = 0;
                int t2 = 0;
                int n = count / 2;
                int[] team1 = new int[n];
                int[] team2 = new int[n];

                for(int i = 0; i < count; i++)
                {
                    if (members[i] == 1)
                    {
                        team1[t1] = i;
                        t1++;
                    }
                    if (members[i] == 2)
                    {
                        team2[t2] = i;
                        t2++;
                    }
                }

                t1 = 0;
                t2 = 0;

                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        t1 += status[team1[i], team1[j]];
                        t2 += status[team2[i], team2[j]];
                    }
                }


                int score = Math.Abs(t1 - t2);
                if (score < min) min = score;
            }

            for(int i = 0; i < 2; i++)
            {
                if(Check(i))
                {
                    teamSpace[i]--;
                    members[depth] = i + 1;
                    
                    DFS(depth + 1);
                    teamSpace[i]++;
                    members[depth] = 0;
                }
            }
        }

        static bool Check(int i)
        {
            if (teamSpace[i] == 0) return false;   
            return true;
        }
    }
}
