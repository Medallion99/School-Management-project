using School_System.Logic.Interface;
using SchoolSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Logic
{
    public class StudentLogic : IStudentLogic
    {
        private readonly Context _ctx;
        public StudentLogic (Context context)
        {
            this._ctx = context;
        }

        public string Addstudent(Student student)
        {
            _ctx.students.Add(student);
            return $"New Student added with id {student.id}";
        }

        public bool DeleteStudent(string id)
        {
            var stud = GetStudents(id);
            if (stud != null)
            {
                _ctx.students.Remove(stud);
                return true;
            }
            return false;
        }

        public Student GetStudents(string id)
        {
            var emp = _ctx.students.FirstOrDefault(x => x.id == id);
            if (emp == null)
            {
                return null;
            }
            return emp;
        }

        public List<Student> GetStudents()
        {
            return _ctx.students.ToList();
        }
    }
}
