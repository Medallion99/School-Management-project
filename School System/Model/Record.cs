using SchoolSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Model
{
    public class Record : Student
    {
        public string StudentId { get; set; }
        public decimal SchoolFees { get; set; }
        public decimal Sportfee { get; set; }
        public decimal Restaurantfee { get; set; }
        public decimal PAfee { get; set; }
        public decimal Books {  get; set; }
        public decimal Total {  get; set; }
        public decimal AnnualFee {  get; set; }

        public int NumberofTerms { get; set; }

    }
}
