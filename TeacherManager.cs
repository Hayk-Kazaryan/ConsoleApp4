using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class TeacherManager   
    {
        List<TeacherModel> _teacheres;

        public TeacherManager()
        {
            _teacheres = new List<TeacherModel>();
        }
        public void Add(TeacherModel teacher)
        {
            _teacheres.Add(teacher);
        }
        public void Update(TeacherModel teacher)
        {
            TeacherModel wrongTeacher = null;
            for (int i = 0; i < _teacheres.Count; i++)
            {
                if (_teacheres[i]._id == teacher._id)
                {
                    wrongTeacher = _teacheres[i];
                    break;
                }
            }
            int wrongTeacherIndex = _teacheres.IndexOf(wrongTeacher);        
            _teacheres[wrongTeacherIndex] = teacher;

        }
        public void Delete(int id)
        {
            TeacherModel teacherForDelete = null;
            for (int i = 0; i < _teacheres.Count; i++)
            {
                if (_teacheres[i]._id == id)
                {
                    teacherForDelete = _teacheres[i];
        
                    break;
                }
            }
            _teacheres.Remove(teacherForDelete);
        }


        public TeacherModel GetTeacher(int id)
        {
            TeacherModel teacher = null;
            for (int i = 0; i < _teacheres.Count; i++)
            {
                if (_teacheres[i]._id == id)
                {
                    teacher = _teacheres[i];
                    break;
                }
            }
        
            return teacher;
        
        }

        public List<TeacherModel> GetTeacheres()
        {
            return _teacheres;
        }
        
    }
    
}
