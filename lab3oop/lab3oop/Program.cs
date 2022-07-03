/** C# Exercire on inheritance and abstract classes 
 Musie Mengesha 
JS5226
SEB*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3oop
{
   abstract class shape
    {
        abstract public double calculateArea();   
        abstract public double calculatePerimeter();
        
    }

    class circle : shape
    {
        static readonly double PI = 3.14;
        public double Radius { get; set; }

        public override double calculateArea()
        {
           return PI*Radius*Radius;
        }

        public override double calculatePerimeter()
        {
            return 2*PI*Radius;
        }
    }
    class Rectangle : shape
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public override double calculateArea()
        {
            return Length*Width;
        }

        public override double calculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            circle c= new circle();
            Rectangle R = new Rectangle();

            c.Radius = 3;
            R.Length = 3;
            R.Width = 4;

            Console.WriteLine("The area of the Circle is : " + c.calculateArea());
            Console.WriteLine("The perimeter of the Circle is : " + c.calculatePerimeter());
            Console.WriteLine("The area of the Rectangle is : " + R.calculateArea());
            Console.WriteLine("The perimeter of the Rectangle is : " + R.calculatePerimeter());

            Console.ReadKey();
        }
    }

}
