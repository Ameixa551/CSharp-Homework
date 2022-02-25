//给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True
using System;

namespace MatrixSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("please input the size of the matrix,row first, col second");
                int m = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                int[,] matrix = new int[m, n];
                
                for(int i =0; i < m; i++)
                {
                    Console.WriteLine("please input the row "+i+" and seperate each with ','");
                    string[] nums = Console.ReadLine().Split(',');
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = int.Parse(nums[j]);   
                    } 
                }

                judge(matrix);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }   
        }
        static void judge(int[ , ] matrix)
        {
            int col = matrix.Rank+1;//列数
            Console.WriteLine(col);
            int row = matrix.GetLength(0);//行数
            Console.WriteLine(row);
            int num = matrix[0,0];//左上角
            bool judge = true;
            for(int i = 1; i < Math.Min(row, col); i++)
            {
                while (judge)
                {
                    if(matrix[i,i]!=num)
                        judge = false;
                }
                break;
            }
            Console.WriteLine("the answer is" + judge);
        }
    }
}
