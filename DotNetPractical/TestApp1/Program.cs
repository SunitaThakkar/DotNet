using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b = 12;
            int c = a ?? b; 

            Nullable<int> i = null;
            if (i.HasValue)
            {
                Console.WriteLine(i.Value);
            }
            else
            {
                Console.WriteLine("null");
            }

            if (Nullable.Compare<int>(a, b) < 0 ){
                Console.WriteLine("a<b");
            }

            else if (Nullable.Compare<int>(a,b) > 0)
            {
                Console.WriteLine("a>b");
            }
            else
            {
                Console.WriteLine("a=b");
            }

            Console.WriteLine(c);
            Console.Read();
        }
    }
}
