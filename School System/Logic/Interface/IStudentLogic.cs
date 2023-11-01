using SchoolSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Logic.Interface
{
    public interface IStudentLogic
    {
        string Addstudent(Student student);
        Student GetStudents(string id);

        bool DeleteStudent(string id);
         List<Student> GetStudents();



    }
}
