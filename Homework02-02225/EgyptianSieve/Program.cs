//用“埃氏筛法”求2~ 100以内的素数
using System;
namespace EgyotianSieve
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input the range(max)");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num <= 1)
                    Console.WriteLine("Wrong input");
                getAns(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());   
            }
        }
        static void getAns(int num)
        {
            //标识数组是否为素数
            bool[] flags = new bool[num+1];
            for(int i = 2; i < num+1; i++)
            {
                flags[i] = true;
            }

            //筛选是否为素数
            for(int i =2; i * i <= num; i++)
            {
                if (flags[i] == true)
                {
                    for(int j=i;j*i<= num; j++)
                    {
                        flags[j * i] = false;
                    }
                }
            }

            //输出
            int k = 0;
            for (int i = 2; i <= num; i++)
            {
                if (flags[i] == true)
                {
                    k++;
                    Console.Write(i + " ");
                    if (k % 6 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
