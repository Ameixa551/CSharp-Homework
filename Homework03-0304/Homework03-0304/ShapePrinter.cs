using System;
//简单工厂模式
namespace Homework03_0304
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shapes = { "Rectangle", "Triangle", "Square", "Circle" };
            Random random = new Random();
            double area = 0;
            Shape shape;
            int i = 0;
            while (i < 10)
            {
                shape = GetShape(shapes[random.Next(1, 4)]);
                if (shape.IsLegal())
                {
                    area+=shape.GetArea();
                    Console.WriteLine(shape.GetInfo());
                    i++;
                }
            }
            Console.WriteLine("The sum of area is :"+area);
        }

        static Shape GetShape(string s)
        {
            Shape shape = null;
            if (s == "Rectangle") 
                shape= new Rectangle();
            else if (s == "Triangle")
                shape = new Triangle(); 
            else if (s == "Square")
                shape = new Square();
            else if (s == "Circle")
                shape = new Circle();
            return shape;
        }
    }
}