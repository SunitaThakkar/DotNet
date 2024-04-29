using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLPractice;


namespace ClassLApp
{   
    public static class Demo
    {
        public static void NewMethod(this Class1 ob)
        {
            Console.WriteLine("Hello I am Extended Method");
        }
    }


    class Program 
    {
        static void Main(string[] args)
        {
            Class1 ob = new Class1();
            ob.method();
            ob.Display();
            ob.NewMethod();
            Console.ReadKey();
        }
    }
}
