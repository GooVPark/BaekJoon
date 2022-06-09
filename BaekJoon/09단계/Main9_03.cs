using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._09단계
{
    internal class Main9_03
    {
        static string text1 = "어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.";
        static string text2 = "\"재귀함수가 뭔가요?\"";
        static string text3_1 = "\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.";
        static string text3_2 = "마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.";
        static string text3_3 = "그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"";
        static string text4 = "\"재귀함수는 자기 자신을 호출하는 함수라네\"";
        static string text5 = "라고 답변하였지.";

        static void Main3(string[] args)
        {
            int dest = int.Parse(Console.ReadLine());
            Console.WriteLine(text1);
            Dialogue(dest, 0);
        }

        static void Dialogue(int dest, int count)
        {
            WritePaddedString(text2, count);

            if(dest == count)
            {
                WritePaddedString(text4, count);
            }
            else
            {
                WritePaddedString(text3_1, count);
                WritePaddedString(text3_2, count);
                WritePaddedString(text3_3, count);
                Dialogue(dest, count + 1);
            }

            WritePaddedString(text5, count);
        }

        static void WritePaddedString(string text, int pading)
        {
            Console.WriteLine(text.PadLeft(text.Length + ((pading) * 4), '_'));
        }
    }
}
