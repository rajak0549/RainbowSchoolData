using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchoolData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStorage dataStorage = DataStorage.Instance;
            SchoolFactory factory = new SchoolFactory();


            var student1 = factory.CreateStudent("Nikhil Singh", "Class X");
            var student2 = factory.CreateStudent("Bob Johnson", "Class XII");

            var teacher1 = factory.CreateTeacher("Mrs Komal Sharma", " Class X");
            var teacher2 = factory.CreateTeacher("Mrs. Sunita Agrawal", "Class XI");

            var subject1 = factory.CreateSubject("Math", "MATH101", teacher1);
            var subject2 = factory.CreateSubject("Science", "SCI101", teacher2);


            dataStorage.Students.Add(student1);
            dataStorage.Students.Add(student2);

            dataStorage.Teachers.Add(teacher1);
            dataStorage.Teachers.Add(teacher2);

            dataStorage.Subjects.Add(subject1);
            dataStorage.Subjects.Add(subject2);


            Console.WriteLine("Students in Class A:");
            foreach (var student in dataStorage.Students.Where(s => s.ClassSection == "Class A"))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(teacher1.Name);
            }


            Console.WriteLine("\nSubjects taught by Teacher 1:");
            foreach (var subject in dataStorage.Subjects.Where(s => s.Teacher == teacher1))
            {
                Console.WriteLine(subject.Name);
            }
            Console.ReadLine();
        }
    }
}
