using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Assemblybaseclass
    {
        private string privatevariable = "Private";
        internal string internalstring = "internal";
        public string publicvalue = "Public";

        public void test()
        {
            Console.WriteLine(privatevariable);
            Console.WriteLine(internalstring);
            Console.WriteLine(publicvalue);
        }
    }

    public class DerivedAssemblyClass : Assemblybaseclass
    {
        public void testInAssembly()
        {
            //private access modifier not working in derived class
            //Console.WriteLine(privatevariable);
            Console.WriteLine(internalstring);
            Console.WriteLine(publicvalue);
        }
    }
    public class OtherAssemblyClass
    {
        public void test()
        {
            Assemblybaseclass obja2 = new Assemblybaseclass();
           // Console.WriteLine(obja2.privatevariable);
            Console.WriteLine(obja2.internalstring);
            Console.WriteLine(obja2.publicvalue);
        }
    }
    class AcessModifiers
    {
        static void Main(string[] args)
        {
            // Assemblybaseclass a1 = new Assemblybaseclass();
            //
            //
            //
            //  a1.test();
            // DerivedAssemblyClass objderived = new DerivedAssemblyClass();
            // objderived.testInAssembly();
            //  objderived.test();
            OtherAssemblyClass objother = new OtherAssemblyClass();
            objother.test();
            Console.ReadLine();
        }
    }
}
