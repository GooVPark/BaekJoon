using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._16단계
{
    internal class Main16_07
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int count = int.Parse(sr.ReadLine());
            int[] nums = new int[count + 1];
            nums[0] = int.Parse(sr.ReadLine());
            string[] s = sr.ReadLine().Split();
            nums[0] = int.Parse(s[0]) + nums[0];
            nums[1] = int.Parse(s[1]) + nums[0];
            for(int i = 1; i < count; i++)
            {
                string[] input = sr.ReadLine().Split();
                int[] inputs = new int[input.Length];
                for (int j = 0; j < input.Length; j++)
                { 
                    inputs[j] = int.Parse(input[j]);
                }
                
                for (int j = 0; j < i; j++)
                {
                    
                    
                }
                for (int k = 0; k < inputs.Length; k++) Console.Write(nums[k] + " ");
                Console.WriteLine();
            }

            int max = int.MinValue;
            for(int i = 0; i < count; i++)
            {
                if (nums[i] > max) max = nums[i];
            }

            Console.WriteLine(max);
        }
    }
}
