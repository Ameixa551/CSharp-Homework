using System;

namespace Homework01_0218_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;

            try
            {
                //输入数字
                Console.WriteLine("input number1:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input number2:");
                num2 = Convert.ToInt32(Console.ReadLine());

                //输入运算符
                Console.WriteLine("input the operator: ");
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"{num1}+{num2} = " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine($"{num1}-{num2} = " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine($"{num1}*{num2} = " + (num1 * num2));
                        break;
                    case "/":
                        Console.WriteLine($"{num1}/{num2} = " + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("The operator is wrong.");
                        break;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is overflow.");
                return;
            }

        }
    }
}
