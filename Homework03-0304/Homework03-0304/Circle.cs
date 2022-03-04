using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//圆形
namespace Homework03_0304
{
    class Circle:Shape
    {
        private double radius;
        public Circle()
        {
            Random rand = new Random();
            this. radius = rand.NextDouble() * rand.Next(10);
        }
        public Circle(double r)
        {
            this.radius = r; 
        }
        public override string GetInfo()
        {
            return "This is a circle.";
        }
        public override double GetArea()
        {
            return this.radius*this.radius*3.14;
        }
        public override bool IsLegal()
        {
            if(this.radius<=0)
                return false;
            else
                return true;
        }
    }
}
