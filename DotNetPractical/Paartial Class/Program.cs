using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paartial_Class
{
    public partial class A
    {
        public int X = 10;
        public int Y = 20;
    }
    public partial class A
    {
        public void method()
        {
            Console.WriteLine(X + Y);
            Console.WriteLine("Partial class method");
        }
    }
         
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.method();
            Console.ReadKey();
        }
    }
}
