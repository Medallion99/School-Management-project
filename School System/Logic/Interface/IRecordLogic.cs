using School_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Logic.Interface
{
    public interface IRecordLogic
    {
        string AddStudentRecord(Record record);
        Record GetRecord(string id);
        bool DeleteRecord(string id);
        List<Record> GetRecords();
        public decimal CalculateTotalStudentFee(decimal schoolfee, decimal sportfee, decimal restaurantfee, decimal books, decimal PAfee);
        public decimal Calculate_Sum_Fee_For_Three_Terms(decimal annual, int numberofTerms);

    }
}
