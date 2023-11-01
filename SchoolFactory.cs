using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchoolData
{
    internal class SchoolFactory
    {
        public Student CreateStudent(string name, string classSection)
        {
            return new Student { Name = name, ClassSection = classSection };
        }

        public Teacher CreateTeacher(string name, string classSection)
        {
            return new Teacher { Name = name, ClassSection = classSection };
        }

        public Subject CreateSubject(string name, string subjectCode, Teacher teacher)
        {
            return new Subject { Name = name, SubjectCode = subjectCode, Teacher = teacher };
        }
    }

}

