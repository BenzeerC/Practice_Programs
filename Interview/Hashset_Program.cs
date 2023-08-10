using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Grade { get; set; }
    }
    public class Hashset_Program
    {
        
        static void Main(string[] args)
        {
            HashSet<Student> set = new HashSet<Student>
            { new Student{Name="Seema",Age=23,Grade="A"},
              new Student{Name="Pallavi",Age=20,Grade="B"},
              new Student{Name="Sunita",Age=21,Grade="C"},
              new Student{Name="Raj",Age=20,Grade="D"},
            };

            

            Console.WriteLine("Student information:\n");
            foreach (var student in set)
            {
                Console.WriteLine($"Name:{student.Name}\n Age:{student.Age}\nGrade:{student.Grade}\n");
            }
        }
    }
}
