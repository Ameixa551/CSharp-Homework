using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//正方形
namespace Homework03_0304
{
    class Square:Shape
    {
        private double length;

        public Square()
        {
            Random random = new Random();
            this.length = random.NextDouble()*random.Next(10);
        }
        public Square(double l)
        {
            this.length = l;
        }
        public override double GetArea()
        {
            return length * length;
        }
        public override bool IsLegal()
        {
            if(length <= 0)
                return false;
            else
                return true;    
        }
        public override string GetInfo()
        {
            return "This is a square.";
        }
    }
}
