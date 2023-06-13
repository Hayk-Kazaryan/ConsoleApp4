using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class StudentModel
    {
        public StudentModel(int id, int age, string name, string faculty)
        {
            _id = id;
            _age = age;
            _name = name;
            _faculty = faculty;

        }


        public int _id;
        public int _age;
        public string _name;
        public string _faculty;
        public TeacherModel _teacher;
    }
}
