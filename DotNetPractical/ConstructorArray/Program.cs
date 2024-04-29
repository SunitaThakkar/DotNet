using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorArray
{
    public class Counstructor
    {
        public int id;
        public string Employeename;
        public float salary;
        public Counstructor(int i , string s  , float sal)
        {
            id = i;
            Employeename = s;
            salary = sal;
        }
        public void method()
        {
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[,] arr = { { 10, 12, 13, 14 }, { 14, 15, 16, 17 } };

            foreach (int i in a1)
            {
                Console.WriteLine(i);
            }
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine(id + "" + Employeename + "" + salary + "");
        }
    }

    class Program
    {
        enum color {Red=5 , Green, Yellow , Til };
        static void Main(string[] args)
        {
            Counstructor c1 = new Counstructor(1 , "Sunita" , 8000f);
            Counstructor c2 = new Counstructor(2, "Dipti", 9000f);
            c1.method();
            c2.method();
            //Console.WriteLine(c.Employeename + "Sunita");
            //Console.WriteLine(c.age + 26);
            int a = (int)color.Green;
            int b = (int)color.Red;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.Read();
        }

    }
}
