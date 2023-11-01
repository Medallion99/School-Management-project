using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Model.Dtos
{
    public class RecordDto
    {
        public string StudentName { get; set; }
        public string RegNumber { get; set; }
        public string Gender { get; set; }
        public string Grade { get; set; }
        public string RegisteredOn { get; set; }
        public string DueOn { get; set; }
        public bool ActiveStatus { get; set; }
        public decimal SchoolFees { get; set; }
        public decimal Sportfee { get; set; }
        public decimal Restaurantfee { get; set; }
        public decimal PAfee { get; set; }
        public decimal Books { get; set; }
        public decimal Total { get; set; }
        public decimal AnnualFee { get; set; }

        public int NumberofTerms { get; set; }
    }
}
