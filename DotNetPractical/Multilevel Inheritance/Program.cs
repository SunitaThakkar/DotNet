using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance
{
    class A
    {
        public int x = 10;
        public int y = 20;
        public A(int x , int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine(x + y);
            Console.WriteLine("This Is Base Class");
        }
        public void Display()
        {
            Console.WriteLine("Hello Class A");
        }
    }
    class B : A
    {
        public B(): base(10 ,30)
        {
            Console.WriteLine("This is a derived class");

        }
        public void da()
        {
            Console.WriteLine("Class b extends a");
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine(x * y);
        }
        public void main()
        {
            Console.WriteLine("This Is Class C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           // B b1 = new B();
           // B b1 = new B();
           // b1.Display();
           // b1.da();
          
            C c = new C();
            c.main();
            c.Display();
            c.da();
            Console.Read();
        }
    }
}
