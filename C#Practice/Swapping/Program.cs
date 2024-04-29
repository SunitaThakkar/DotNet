using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{

    public class A
    {
        public int X = 10;
        public int Y = 20;
        public int Z =30;
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            //int c = a.X;
            //a.X = a.Y;
            //a.Y = c;
            //a.X = a.X + a.Y + a.Z;
            //a.Y = a.X - (a.Y + a.Z);
            //a.Z = a.X - (a.Y + a.Z);
            //a.X = a.X - (a.Y + a.Z);

            a.X = a.X + a.Y;
            a.Y = a.X - a.Y;
            a.X = a.X - a.Y;
            

            Console.WriteLine(a.X +" "+ a.Y + " " + a.Z);
            Console.WriteLine(a.X + " " + a.Y );
            Console.ReadKey();
        }
    }
}
