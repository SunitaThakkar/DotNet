using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAndStaticConstructor
{
    public class Examplee
    {
        private static int Counter;
        static Examplee()
        {
            Counter = 20;
        }
        public Examplee(int counter)
        {
            Counter = Counter + counter;
        }
        public static int GetCounter()
        {
            return ++Counter;
        }
       
    }
    class psconstructor
    {
        static void Main(string[] args)
        {
            Examplee ex = new Examplee(10);
            Console.WriteLine("Counter: {0} ", Examplee.GetCounter());
            Console.ReadLine();
        }
    }
}
