using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchoolData
{
    internal class DataStorage
    {
        private static DataStorage instance;

        private DataStorage() { }

        public static DataStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataStorage();


                }
                return instance;
            }
        }

        public List<Student> Students { get; } = new List<Student>();
        public List<Teacher> Teachers { get; } = new List<Teacher>();
        public List<Subject> Subjects { get; } = new List<Subject>();
    }

}
