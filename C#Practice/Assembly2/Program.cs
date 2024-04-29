using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1;


namespace Assembly2
{
    public class DevivedAssembly2Class: Assemblybaseclass
    {
        public void test()
        {
         //   Console.WriteLine(privatevariable);
          //  Console.WriteLine(internalstring);
            Console.WriteLine(publicvalue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DevivedAssembly2Class Da = new DevivedAssembly2Class();
            Da.test();
            Console.ReadLine();
        }
    }
}
