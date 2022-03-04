using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//三角形
namespace Homework03_0304
{
    class Triangle:Shape
    {
        private double base_length;
        private double height_length;

        public Triangle()
        {
            Random rand = new Random();
            this.base_length = rand.NextDouble()*rand.Next(10);
            this.height_length = rand.NextDouble()*rand.Next(10);
        }
        public Triangle(double b,double h)
        {
            this.base_length = b;
            this.height_length = h;
        }
        public override string GetInfo()
        {
            return "This is a triangle";
        }
        public override bool IsLegal()
        {
            if(this.base_length<=0||this.height_length<=0)
                return false;
            else
                return true;
        }
        public override double GetArea()
        {
            return this.base_length*this.height_length/2;
        }
    }
}
