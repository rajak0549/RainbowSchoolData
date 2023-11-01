using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchoolData
{
    internal class Student
    {
        public string Name { get; set; }
        public string ClassSection { get; set; }
    }

    // Teacher.cs
    public class Teacher
    {
        public string Name { get; set; }
        public string ClassSection { get; set; }
    }

    // Subject.cs
    public class Subject
    {
        public string Name { get; set; }
        public string SubjectCode { get; set; }
        public Teacher Teacher { get; set; }

    }
}
