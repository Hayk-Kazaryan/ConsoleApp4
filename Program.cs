using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudantManager studantManager = new StudantManager();
            TeacherManager teacherManager = new TeacherManager();
            UniversityManager universityManager = new UniversityManager();


            for (int i = 0; i < 10; i++)  
            {
                StudentModel student = new StudentModel(i, 18 + i, $"Ashot {i}", "Math");
                student._teacher = new TeacherModel(i, 55 + i, "Kambo");
                studantManager.Add(student);
            }
            List<StudentModel> students = studantManager.GetStudents();
            //universityManager.Show(students);


            for (int i = 0; i < 3; i++)
            {
                TeacherModel teacher = new TeacherModel(i, 50 + i, $"Vaxarshak {i}");
                teacherManager.Add(teacher);
            }
            List<TeacherModel> teachers = teacherManager.GetTeacheres();

            //universityManager.Show(teachers);

            universityManager.Swap(students, teachers);

            universityManager.Show(teachers);
            Console.WriteLine("asd");

        }
    }
}