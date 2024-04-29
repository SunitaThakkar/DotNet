using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverHiding_NewKeyword_
{
    public class Ass
    {
        //public Ass()
        //{
        //    Console.WriteLine("Ass");
        //}
        public virtual void Show()
        {
            Console.WriteLine("This Is Base class");
        }
        public  void Method()
        {
            Console.WriteLine("A + B " ,  10 + 20);
        }
    }

    public class BSS : Ass
    {
        //public BSS() : base()
        //{
        //    Console.WriteLine("BSS");
        //}
        public override void Show()
        {
            Console.WriteLine("This Is Derived Class");
        }
        public  new void Method()
        {
            Console.WriteLine("A + B + C  ");
        }
    }
    public class CSS : BSS
    {
        public CSS() : base()
        {
            Console.WriteLine("CSS");
        }
        public new void Show()
        {
            Console.WriteLine("This Is CSS Derived Class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ass a = new Ass();
            a.Show();
            a.Method();
           // BSS b = new BSS();
          //  b.Show();
          //  b.Method();
            CSS c = new CSS();
            c.Method();
            c.Show();
            Console.ReadKey();
        }
    }
}
