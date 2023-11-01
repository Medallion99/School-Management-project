using School_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Model
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string RegNumber {  get; set; } = GenerateRegNum();
        public string Gender { get; set; } = "";
        public string Age { get; set; } = "";
        public string Grade { get; set; } = "";
        public bool ActiveStatus { get; set; }
        public string RegisterOn { get; set; } = "";
        public string ToPayOn { get; set; } = "";

        public static string GenerateRegNum ()
        {
            Random random = new Random();
            string regNum = "CSSN" + random.Next(200, 300);
            return regNum;
        }

    }
}
