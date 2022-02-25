//程序输出用户指定数据的所有素数因子
using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input a positive num:\n>>");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num <= 1)
                {
                    Console.WriteLine("Wrong input");
                }

                GetPrime(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());   
            }
        }
        static void GetPrime(int num)
        {
            List<int> pris = new List<int>();
            for(int pri = 2; pri < num; pri++)
            {
                while(num % pri == 0 &&pri!=num)
                {
                    pris.Add(pri);  
                    num /= pri;
                }
            }
            pris.Add(num);
            foreach (var pri in pris)
            {
                Console.WriteLine(pri);
            }

            pris.Add(num);
        }
    }
}