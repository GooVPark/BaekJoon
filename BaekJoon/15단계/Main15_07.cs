using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._15단계
{
    internal class Main15_07
    {
        static int numberCount = 0;
        static int[] operators = new int[4];
        static int[] sequence;
        static int[] numbers;

        static int max = int.MinValue;
        static int min = int.MaxValue;
        static void Main7(string[] args)
        {
            numberCount = int.Parse(Console.ReadLine());
            numbers = new int[numberCount];
            string[] numberInputs = Console.ReadLine().Split();
            string[] operatorInputs = Console.ReadLine().Split();

            for (int i = 0; i < numberCount; i++) numbers[i] = int.Parse(numberInputs[i]);
            for(int i = 0; i < 4; i++) operators[i] = int.Parse(operatorInputs[i]);
            
            sequence = new int[numberCount - 1];
            

            Calc(0);


            Console.WriteLine($"{max}");
            Console.WriteLine($"{min}");
        }

        static void Calc(int level)
        {
            if(level == numberCount - 1)
            {
                int result = numbers[0];
                for(int i = 0; i < numberCount -1; i++)
                {
                    if (sequence[i] == 1) result += numbers[i + 1];
                    if (sequence[i] == 2) result -= numbers[i + 1];
                    if (sequence[i] == 3) result *= numbers[i + 1];
                    if (sequence[i] == 4) result /= numbers[i + 1];
                }

                if(result > max) max = result;
                if(result < min) min = result;
            }


            for(int i = 0; i < 4; i++)
            {
                if (Check(i))
                {
                    operators[i]--;
                    sequence[level] = i+1;
                    Calc(level + 1);
                    operators[i]++;
                }
            }
        }

        static bool Check(int i)
        {
            if (operators[i] == 0) return false;
            else return true;
        }

    }
}
