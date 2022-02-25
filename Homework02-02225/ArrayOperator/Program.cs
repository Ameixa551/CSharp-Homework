//求一个整数数组的最大值、最小值、平均值和所有数组元素的和
using System;

namespace ArrayOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //获取输入
                Console.WriteLine("Please input the length of the array");
                int length = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[length];
                Console.WriteLine("please input the numbers");//用回车拆解每个输入
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Max:" + maxNum(nums));
                Console.WriteLine("Min:" + minNum(nums));
                Console.WriteLine("Average:" + averNum(nums));
                Console.WriteLine("Sum:" + sumNum(nums));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //求最大值
        static int maxNum(int[] nums)
        {
            int max = 0;
            foreach (int i in nums)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        //求最小值
        static int minNum(int[] nums)
        {
            int min = 0;
            foreach(int i in nums)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
        //求平均值
        static int averNum(int[] nums)
        {
            int aver = 0;
            foreach( int i in nums)
            {
                aver += i;
            }
            aver = aver / nums.Length;
            return aver;
        }
        //求和
        static int sumNum(int[] nums)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }
        }
    }

