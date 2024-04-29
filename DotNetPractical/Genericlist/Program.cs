using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Genericlist
{

    class GenericList
    {
        public static void Main(String[] args)
        {

            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(5);
            lst.Add(10);

            Console.WriteLine(lst.Sum());
            Console.WriteLine(lst.Count());

            var name = new List<string>();
            name.Add("Sunita");
            name.Add("Dipti");
            name.Add("Ali");

            Console.WriteLine("no of name" + name.Count());

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Sunita");
            arrayList.Add(" ");
            arrayList.Add(true);
            Console.WriteLine("Arraylist 1 Elements");

            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine(arrayList[i]);

            var arraylist2 = new ArrayList()
            {
                2 , "Dipti" , "Surat"
            };
            Console.WriteLine("Arraylist 2 Elecments");
            for (int i = 0; i < arraylist2.Count; i++)
                Console.WriteLine(arraylist2[i]);

            string[] cities = new string[3] { "Mumbai", "Gujarat", "MP" };

            var popularcities = new List<string>();

            popularcities.AddRange(cities);

            var favurioutecities = new List<string>();

            favurioutecities.AddRange(popularcities);

            Console.WriteLine(popularcities.Count);
            Console.WriteLine(favurioutecities.Count);

            SortedList<int, string> numbersname = new SortedList<int, string>()
            {
                { 1, "one" },
                { 2, "Two" },
                { 3, "Three" },
                { 4, "four" },
            };
            numbersname.Remove(1);
            numbersname.Remove(10);

            numbersname.RemoveAt(0);

            foreach (var i in numbersname)
                Console.WriteLine("key: {0} , value {1} ", i.Key, i.Value);

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "Three");


            Hashtable hs = new Hashtable(dict);

            Console.WriteLine("Total elements: {0}" , hs.Count);



         
        }
      
    }
}