using System;
using System.Reflection.Metadata.Ecma335;

namespace FunctionDelegates
{
    class  B
    {
        public static int demo(int num)
        {
            return num + num;
        }

        public static void demo2(int p , int q)
        {
            Console.WriteLine  (p - q);
        }
        public static int mymethod(int a , int b , int c , int d)
        {
            return a * b * c; 
        }

        public static bool Function(string str)
        {
            if (str.Length < 7 )
            {
               return true;
            }
            else
            {
                return false;
            }
        }

        static public void Main()
        {
            Func<int, int, int, int , int> val = mymethod;
            Console.WriteLine(val(10, 100, 1000, 1));

            Func<int, int > val2 = demo;
            Console.WriteLine(val2(10));

            Action<int, int> action = demo2;
            action(20, 2);

            Predicate<string> predicate = Function;
            Console.WriteLine(predicate("Hello"));

        }
    }
}
