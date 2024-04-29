using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstructor
{
   public class Student
    {
        public int StudentID { get; set; }

        public string name { get; set; }

        public string collage { get; set; }
        public Student()
        {
            collage = "NTC";
        }
        public Student(int studentID , string Name , string Collage)
        {
            this.StudentID = studentID;
            this.name = Name;
            this.collage = Collage;
        }
        public Student(int studentID, string Name)
        {
            this.StudentID = studentID;
            this.name = Name;
            
        }
    }

   
    class Defaultconstructor
    {
        static void Main(string[] args)
        {
          //  Student St = new Student();
            //Console.WriteLine("StudentID : {0} , name : {1} , Collage : {2}", St.StudentID, St.name, St.collage);
            //Console.ReadLine();
            //Student St = new Student( 1, "Sunita" , "KJIT");
           // Console.WriteLine("StudentID : {0} , name : {1} , Collage : {2}", St.StudentID, St.name, St.collage);
            //Console.ReadLine();
            Student St = new Student(1, "Sunita");
            Console.WriteLine("StudentID : {0} , name : {1} , Collage : {2}", St.StudentID, St.name, St.collage);
            Console.ReadLine();
        }
    }
}
