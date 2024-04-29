using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        //enum
        enum fan { low, medium = 4, high };

        static void Main(string[] args)
        {
            //Datatypes in c#
            int val = 100000;
            long l1 = 1500000000000;
            float f = 5.71f;
            double d = 37.27d;
            bool helo = false;
            bool hello = true;
            char capital = 'A';
            String s = "Hello";
            Console.WriteLine("Integer : " + val);
            Console.WriteLine("Long :" + l1);
            Console.WriteLine("Float :" + f);
            Console.WriteLine("Double :" + d);
            Console.WriteLine("Booleans False :" + helo);
            Console.WriteLine("Boolean True :" + hello);
            Console.WriteLine("Character :" + capital);
            Console.WriteLine("String : " + s);


            //Implicit Typecasting
            int a = 97;
            double doub = a;

            Console.WriteLine(doub);
            Console.WriteLine(a);


            //explicit typecasting
            double l = 19.73;
            int i = (int)l;

            Console.WriteLine(i);
            Console.WriteLine(l);

            //type conversion methods
            int myint = 10;
            double mydouble = 17.17;
            bool mybool = false;

            Console.WriteLine("Convert Integer to string : " + Convert.ToString(myint));
            Console.WriteLine("Convert Integer to Double : " + Convert.ToDouble(myint));
            Console.WriteLine("Convert Double to Integer : " + Convert.ToInt16(mydouble));
            Console.WriteLine("Convert Boolean False To Integer : " + Convert.ToInt16(mybool));


            //user input
            Console.Write("Enter Username : ");
            string username = Console.ReadLine();
            Console.WriteLine("Username is :" + username);


            Console.Write("Enter Age : ");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Age is : " + age);

            //var and dynamic
            var r = 12.18;
            dynamic name = "Disha";
            Console.WriteLine(r);
            Console.WriteLine(name);

            fan f3 = fan.high;
            Console.WriteLine(f3);


            fan f2 = fan.medium;
            Console.WriteLine(f2);


            int checkmedium = (int)fan.medium;
            Console.WriteLine("Check Fan Medium Value :" + checkmedium);
            int checkhigh = (int)fan.high;
            Console.WriteLine("Check Fan Medium Value :" + checkhigh);
            int checkhlow = (int)fan.low;
            Console.WriteLine("Check Fan Medium Value :" + checkhlow);
            Console.ReadLine();
        }
    }
}