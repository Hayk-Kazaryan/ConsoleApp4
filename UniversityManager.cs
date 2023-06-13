using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class UniversityManager
    {
        public void Show(List<StudentModel> students)
        {
            for(int i =0; i<students.Count; i++)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("name-{0} age-{1} faculty-{2} id-{3}", students[i]._name, students[i]._age, students[i]._faculty, students[i]._id);
                if (students[i]._teacher != null)
                {
                    TeacherModel teacher = students[i]._teacher;
                    Console.WriteLine("name-{0} age-{1}  id-{2}", teacher._name, teacher._age, teacher._id);
                }
            }

        }
        public void Show(List<TeacherModel>  teachers)
        {
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("name-{0} age-{1} id-{2}", teachers[i]._name, teachers[i]._age, teachers[i]._id);
                if (teachers[i]._students != null)
                {
                    for(int j=0; j< teachers[i]._students.Count; j++)
                    {
                        Console.WriteLine("name-{0} age-{1} faculty-{2} id-{3}", teachers[i]._students[j]._name, teachers[i]._students[j]._age, teachers[i]._students[j]._faculty ,teachers[i]._students[j]._id);

                    }
                }
            }
        }

        public List<TeacherModel> Swap(List<StudentModel> students, List<TeacherModel> teachers)
        {
            int eachCount = (students.Count / teachers.Count);
            int counter = 0;

            for(int i=0; i<teachers.Count; i++)
            {
                for(int j=0; j<students.Count; j++)
                {
                    teachers[i]._students.Append(students[j]);//STE INCH VOR ARJEQ NULL_A DRANIC CHI ASHXATUM
                    if(counter == eachCount)
                    {
                        counter = 0;
                        break;
                    }
                }
            }
            return teachers;
        }

    }
}
