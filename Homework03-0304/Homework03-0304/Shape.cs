using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//图形抽象类
namespace Homework03_0304
{
    abstract class Shape
    {
        public abstract double GetArea();  // 计算图形面积
        public abstract bool IsLegal();  // 判断图形是否合法
        public abstract string GetInfo();  // 返回图形信息
    }
}
