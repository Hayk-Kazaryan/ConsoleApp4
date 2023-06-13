using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class StudantManager
    {
        List<StudentModel> _students;
    
        public StudantManager()
        {
            _students = new List<StudentModel>();
        }

        public void Add(StudentModel student)
        {
            _students.Add(student);
        }

        public void Update(StudentModel student)
        {
            StudentModel wrongStudent = null;

            for(int i = 0; i < _students.Count; i++)
            {
                if(_students[i]._id == student._id)
                {
                    wrongStudent = _students[i];
                    break;
                }
            }
            int wrongStudentIndex = _students.IndexOf(wrongStudent);
            _students[wrongStudentIndex] = student;


        }

        public void Delete(int id)
        {
            StudentModel studentForDelete = null;

            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == id)
                {
                    studentForDelete = _students[i];
                    break;
                }
            }
            _students.Remove(studentForDelete);

        }

        public StudentModel GetStudent(int id)
        {
            StudentModel student = null;
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == id)
                {
                    student = _students[i];
                    break;
                }
            }
            return student;
        }
        
        public List<StudentModel> GetStudents()
        {
            return _students;
        }
    }
}
