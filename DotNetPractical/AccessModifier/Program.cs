using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{  

  public  class Test
    {
        public int id = 1;
        private string name = "Sunita";
        protected string Dep = "CE";
       // internal protected string  LastName = "Thakkar";
        internal  float f = 13.4F;

       

        public Test()
        {

        }
        public void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
   
   public class Program : Test
    {
        
        static void Main(string[] args)
        {
            Test t = new Test();
            Console.WriteLine(t.id);
            Console.WriteLine(t.f);
            Program p = new Program();
            //Test2 test = new Test2();
            //test.Msg("Hello");
            Console.WriteLine("Hello" + p.Dep);
            p.Msg("EC");
            Console.ReadKey();
        }
    }
}

