using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   //public class Employee
   // {
   //     public float Salary = 4000;
   // }

   // public class Program : Employee
   // {
   //     public float bonous = 5000;
   // }
   // class Inheritance
   // {
   //     static void Main(string[] args)
   //     {
   //         Program p1 = new Program();
   //         Console.WriteLine("Bonous:" + p1.bonous);
   //         Console.WriteLine("Salary:"+ p1.Salary);
   //         Console.ReadLine();
   //     }   
   // }

    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating....");
        }
    }

    public class DOG : Animal
    {
        public void Bark()
        {
            Console.WriteLine("bow bow");
        }
    }

    public class BabyDog : DOG
    {
        public void Weap()
        {
            Console.WriteLine("Weaping");
        }
    }
    public class singleinheritance
    {
        public static void Main(string[] args)
        {
            BabyDog d = new BabyDog();
            d.Bark();
            d.Eat();
            d.Weap();
            Console.Read();
        }

    }
}
