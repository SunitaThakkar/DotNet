using System;

namespace DelegatesEx1
{
    class A
    {
        public delegate void Value(int n);
        public delegate void addnum(int x , int y);

        public delegate void mulnum(int x , int y);

        public void Sum(int x , int y)
        {
            Console.WriteLine("(10 + 20)  = {0} " , x + y);
        }

        public void Mul(int x, int y)
        {
            Console.WriteLine("(50 * 10)  = {0} ", x * y);
        }

        public static void Main(string[] args)
        {
            A a = new A();

            addnum del_obj1 = new addnum(a.Sum);
            mulnum del_obj2 = new mulnum(a.Mul);

            del_obj1(10, 20);
            del_obj2(50, 10);

            int i = 10;
            Value val = delegate (int m)
            {
                m += i;
                Console.WriteLine("Anonymous Method: {0}", m);

            };
            val(100);
        }
    }

   
}

