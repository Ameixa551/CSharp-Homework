using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//长方形
namespace Homework03_0304
{
    class Rectangle:Shape
    {
        private double length;
        private double width;
        public Rectangle()
        {
            Random random = new Random();
            this.length = random.NextDouble()*random.Next(10);
            this.width = random.NextDouble() * random.Next(5);
        }
        public Rectangle(double l,double w)
        {
            this.length = l; 
            this.width = w; 
        }
        public override bool IsLegal()
        {
            if(this.length<=0||this.width<=0)
                return false;
            else
                return true;
        }
        public override double GetArea()
        {
            return length * width;
        }
        public override string GetInfo()
        {
            return "This is a rectangle";
        }
    }
}
