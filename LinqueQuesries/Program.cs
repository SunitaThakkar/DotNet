using System;
using System.Collections;

namespace LinqueQuesries
{
    class Program
    {
        public static void Main()
        {

            IList<Student> studentlst = new List<Student>()
            {
                new Student() {Id = 1, Name = "Sunita" , Age= 13 },
                new Student() {Id = 2, Name = "Shubham" , Age= 21 },
                new Student() {Id = 3, Name = "Ali" , Age= 15 },
                new Student() {Id = 4, Name = "Dipti" , Age= 22 }

            };

            var teenage = from student in studentlst
                          where student.Age > 12 && student.Age < 20
                          select student;

            Console.WriteLine(teenage);

            foreach (Student s in teenage) 
            {
                Console.WriteLine(s.Name);
            }

            IList Mixedlist = new ArrayList();
            Mixedlist.Add(0);
            Mixedlist.Add("One");
            Mixedlist.Add("Two");
            Mixedlist.Add(new Student() { Id = 5 , Name="Sanju" });

            var stringresult = from s in Mixedlist.OfType<string>()
                               select s;

            var intresult = from std in Mixedlist.OfType<int>()
                               select std;

            var stdresult = from st in Mixedlist.OfType<Student>()
                            select st;


            foreach (var i in stdresult)
            {
                Console.WriteLine(i);
            }

            foreach (var it in intresult)
            {
                Console.WriteLine(it);
            }

            foreach(var student in stringresult)
            {
                Console.WriteLine(student);
            }

            var orderbyascresult = from s in studentlst
                                orderby s.Name 
                                select s;
            Console.WriteLine(orderbyascresult);

            foreach (var student in orderbyascresult)
            {
                Console.WriteLine(student.Name);
            }

            var orderbyresult = from  s in studentlst
                                orderby s.Name descending
                                select s;

            Console.WriteLine("Decendingorder");

            foreach (var student in orderbyresult)
            {
                Console.WriteLine(student.Name);
            }

            var thenbyreult = studentlst.OrderBy(s => s.Name).ThenBy(s => s.Age);

            var thenDescresult = studentlst.OrderByDescending(s => s.Name).ThenByDescending(s => s.Age);

            Console.WriteLine("ThenByResult");

            foreach(var student in thenbyreult)
            {
              Console.WriteLine("Name : {0} , Age={1}",student.Name , student.Age);
            }

            Console.WriteLine("ThenDescResult");

            foreach(var std in thenDescresult)
            {
                Console.WriteLine("Name : {0} , Age={1}", std.Name, std.Age); ;
            }

            var groupby = from s in studentlst
                          group s by s.Age;

            foreach (var agegroup in groupby)
            {
                Console.WriteLine("AgeGroup : {0}", agegroup.Key);
                  foreach(var student in agegroup)
                {
                    Console.WriteLine("Student Name: {0}" , student.Name);
                }
            }

            var groupbyresult =  studentlst.GroupBy(s => s.Age);

            foreach (var ageg in groupbyresult)
            {
                Console.WriteLine("AgeGroup : {0}", ageg.Key);
                foreach (var student in ageg)
                {
                    Console.WriteLine("Student Name: {0}", student.Name);
                }
            }

            IList<string> list = new List<string>()
            {
                "One" ,
                "Two" ,
                "Three"
            };

            IList<string> lst = new List<string>()
            {
                "One",
                "Five",
                "Six"
            };

            var innerjoin = list.Join(lst,
                             str1 => str1,
                             str2 => str2,
                             (str1, str2) => str1);

            foreach(var i in innerjoin)
            {
                Console.WriteLine("{0}" , i);
            }


        }
    }


    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }


    }

    public class Standard
    {
        public int stdId { get; set; }

        public string stdName { get; set; }
    }
}