//为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralList<int> list = new GeneralList<int>();
            for(int i = 5; i < 20; i++)
                list.add(i);
            list.Foreach(m => Console.WriteLine(m));

            int max =int.MinValue;
            list.Foreach(m => { if (m > max) max = m; });
            Console.WriteLine("The max value is "+max);

            int min = int.MaxValue;
            list.Foreach(m => { if (m < min) min = m; });
            Console.WriteLine("The min value is " + min);

            int sum = 0;
            list.Foreach(m => sum +=m);
            Console.WriteLine("The sum value is " + sum);
        }
    }
}
