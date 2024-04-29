using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Index
    {
        private string[] FruitList = new string[5];
        

        public string this [int index]
        {
            get
            {
                return FruitList[index];
            }
            set
            {
                FruitList[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Index i = new Index();
            i[0] = "Banana";
            i[1] = "Apple";
            i[2] = "Graps";
            i[3] = "Pineple";
            i[4] = "Strawberry";
            Console.WriteLine("Fruit List");
            Console.WriteLine(i[0]);
            Console.WriteLine(i[1]);
            Console.WriteLine(i[2]);
            Console.WriteLine(i[3]);
            Console.WriteLine(i[4]);
            Console.ReadKey();
           
        }
    }
}

