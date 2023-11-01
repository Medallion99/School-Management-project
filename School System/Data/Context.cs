using School_System.Model;
using SchoolSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Logic
{
    public class Context
    {
        public IList<Student> students { get; set; } = new List<Student>();
        public IList<Record> records { get; set; } = new List<Record>();
    }
}
