using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Abstract
    {
        public abstract void Print();
        public  void Show()
        {
            Console.WriteLine("AbstactMethod Show");
        } 
    }
    public class Bal : Abstract
    {
        public sealed override void Print()
        {
            Console.WriteLine("Hello ");
        }

    } 

    public class Csharp : Bal
    {
        public  new void  Print()
        {
            Console.WriteLine("Bye");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Csharp c = new Csharp();
            Abstract a = new Bal();
            a.Show();
            a = new Csharp();
            a.Print();
            Console.ReadKey();
        }
    }
}
