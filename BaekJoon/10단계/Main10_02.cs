using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._10단계
{
    internal class Main10_02
    {
        static void Main2(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i7 = 0; i7 < 10; i7++)
            {
                for (int i6 = 0; i6 < 10; i6++)
                {
                    for (int i5 = 0; i5 < 10; i5++)
                    {
                        for (int i4 = 0; i4 < 10; i4++)
                        {
                            for (int i3 = 0; i3 < 10; i3++)
                            {
                                for (int i2 = 0; i2 < 10; i2++)
                                {
                                    for (int i1 = 0; i1 < 10; i1++)
                                    {
                                        int wholeNumber = (i7 * 1000000) + (i6 * 100000) + (i5 * 10000) + (i4 * 1000) + (i3 * 100) + (i2 * 10) + i1;
                                        int sum = wholeNumber + i7 + i6 + i5 + i4 + i3 + i2 + i1;
                                        if (wholeNumber > number)
                                        {
                                            Console.WriteLine(0);
                                            return;
                                        }
                                        if (sum == number)
                                        {
                                            Console.WriteLine($"{wholeNumber} {i7} {i6} {i5} {i4} {i3} {i2} {i1}");
                                            Console.WriteLine(wholeNumber);
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
