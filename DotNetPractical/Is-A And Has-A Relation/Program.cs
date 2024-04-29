using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_And_Has_A_Relation
{
    public class Data
    {
        public string fruitname, color;
        public Data(string fruitname , string color)
        {
            this.fruitname = fruitname;
            this.color = color;

        }
    }   
    public class A
    {
        public int id;
        public string name;
        public Data data;
        public A(int a , string n , Data data)
        {
            id = a;
            name = n;
            this.data = data; 
        }
        public void display()
        {
            Console.WriteLine(id + "" + name + "" + data.fruitname + "" + data.color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Data data1 = new Data("Banana", "Yellow");
            A a = new A(1 ,"Sunita" , data1);
            a.display();
            Console.ReadKey(); 
            

        }
    }
}
