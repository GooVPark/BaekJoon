using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_08
    {
        static void Main8(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            string num1 = nums[0];
            string num2 = nums[1];


            //49 빼면 숫자다

            num1 = new String(num1.ToCharArray().Reverse().ToArray());
            num2 = new String(num2.ToCharArray().Reverse().ToArray());

            char[] longNumber;
            char[] shortNumber;

            if (num1.Length >= num2.Length)
            {
                longNumber = new char[num1.Length];
                shortNumber = new char[num2.Length];

                longNumber = num1.ToCharArray();
                shortNumber = num2.ToCharArray();
            }
            else
            {
                longNumber = new char[num2.Length];
                shortNumber = new char[num1.Length];

                longNumber = num2.ToCharArray();
                shortNumber = num1.ToCharArray();
            }

            bool isOver = false;

            for (int i = 0; i < longNumber.Length; i++)
            {
                int unit = 0;
                if (i >= shortNumber.Length) unit = (longNumber[i] - 48);
                else unit = (shortNumber[i] - 48) + (longNumber[i] - 48);

                if (unit >= 10)
                {
                    if(i + 1 == longNumber.Length)
                    {
                        isOver = true;
                    }
                    else
                    {
                        longNumber[i + 1] = (char)(longNumber[i + 1] + 1);
                    }
                    longNumber[i] = (char)(unit - 10 + 48);
                }
                else
                {
                    longNumber[i] = (char)(unit + 48);
                }
            }

            longNumber = longNumber.Reverse().ToArray();
            if (isOver) Console.Write(1);
            foreach (char c in longNumber) Console.Write(c);
        }
    }
}
