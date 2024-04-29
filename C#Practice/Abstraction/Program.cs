using DotLiquid.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Shape
    {
        public abstract void draw();
    }

    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("This Is Circle");
        }
    }
    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("This Is Rectangle");
        }
    }
    public  class TestAbstract
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.Read();
        }
    }
}
