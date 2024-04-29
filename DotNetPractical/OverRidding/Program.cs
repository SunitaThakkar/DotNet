using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverRidding
{
    public class Father
    {
        public int n1 = 10, n2 = 20;
       public Father()
        {
            Console.WriteLine("This Is Base Class");
        }
        public Father(int x , int y)
        {
           this.n1 = x;
           this.n2 = y;
        }
        public virtual void Show()
        {
            Console.WriteLine(n2 + n1);
        }
    }
    public class Son : Father
    {
        public Son() : base ()
        {
            Console.WriteLine("This Is DerivedvClass");
        }
        public Son(int x , int y) : base (x , y)
        {
            Console.WriteLine( y - x);
        }
        public  override void Show()
        {
            Console.WriteLine(n1*n2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Father f = new Father();
            f.Show();
            Son s = new Son();
            Son s1 = new Son(15, 25);
            f = s;
            f.Show();
            Console.ReadKey();
            
            

        }
    }
}
