using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public static class Test
    {
       
        public static int num { get; set; }
        public static float val { get; set; }
        public static string name { get; set; }


        static Test()
        {

        }
        public static void MyMethod()
        {
            num = 1;
            val = 45.2f;
            name = "Sunita";
            Console.WriteLine(num);
            Console.WriteLine(val);
            Console.WriteLine(name);
            Console.Read();
        }


    }

   public class B {
        public static int x;
        public static string add;
        public int age;
        public static int m;
        public static int n;
        public  int? D = null;
        public int E = 4;
        
       
        public B()
        {

        }
        public static void Main(string[] args)
        {
            B b = new B();

            B.x = 12;
            B.add = "Surat";
            b.age = 26;
            B.m = 36;
            B.n = 45;
            Console.WriteLine(x);
            Console.WriteLine(add);
            Console.WriteLine(b.age);
            Animal a = new Animal();

            a.AnimalName = "Dog";
            a.id = 1;
            a.Name = "Sunita1";
            a.Dogtype = "Home";
            //a.Doghome ="Society";

            //Nullable Value
            Nullable<int> i = null;
            if (i.HasValue)
            {
                Console.WriteLine(i.Value);
            }
           else
            {
                Console.WriteLine("Null");
            }

            int? s1 = null;
            int p = 12;
            int s2 = s1 ?? p;
            int j = s1 ?? 0;
            Console.WriteLine(s2);
            Console.WriteLine(j);
            if (Nullable.Compare<int>(s1, p) < 0)
                Console.WriteLine("s1<p");
            else if (Nullable.Compare<int>(s1, p) > 0)
                Console.WriteLine("s1>p");
            else
                Console.WriteLine("s1=p");
            





            Console.WriteLine(a.id);
            Console.WriteLine(a.Name);
            Console.WriteLine(a.AnimalName);
            Console.WriteLine(a.Dogtype);
            Console.WriteLine(a.Dogtype);
            a.Show(out m);
            a.Data(ref n);
            Console.WriteLine(m);
            Console.WriteLine(n);
            Test.MyMethod();
            Console.Read();
        }

        
    }

    public class Animal
    {
        public Animal()
        {

        }
        public int id { get; set; } // feild 
        public string Name { get; set; } //feild

    
        

        public string AnimalName;
        public string Dogtype;

        public string DogType { get; }

        //  public string Doghome { set; }
        public string Animalname
        {
            get { return AnimalName; } // get method 
            set { AnimalName = value; } // set method 
        }

        public void Show(out int a)
        {
            a = 26;
            var b = a++;
        }

        public void Data(ref int P)
        {
            P = 15;
            var Q = P--;
        }

    }

}
