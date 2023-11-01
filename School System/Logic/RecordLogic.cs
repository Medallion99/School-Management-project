using School_System.Logic.Interface;
using School_System.Model;
using SchoolSystem.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Logic
{
    public class RecordLogic : IRecordLogic
    {
        private readonly Context _ctx;
        public RecordLogic(Context context)
        {
            _ctx = context;
        }

        public string AddStudentRecord(Record record)
        {
            record.Total = this.CalculateTotalStudentFee(record.SchoolFees,
                                                           record.Sportfee,
                                                           record.Restaurantfee,
                                                           record.PAfee,
                                                           record.Books
                                                           );

            record.AnnualFee = Calculate_Sum_Fee_For_Three_Terms(record.Total, record.NumberofTerms);
            _ctx.records.Add( record );
            return $"New Record Added for student with id {record.id}";
        }

        public decimal CalculateTotalStudentFee(decimal schoolfee, decimal sportfee, decimal restaurantfee, decimal books, decimal PAfee)
        {
            var total = schoolfee + sportfee + restaurantfee + books + PAfee;
            return total;

        }

        public decimal Calculate_Sum_Fee_For_Three_Terms(decimal annual, int numberofTerms)
        {
            return annual * numberofTerms;
        }

        public bool DeleteRecord(string id)
        {
            var rec = GetRecord(id);
            if (rec != null)
            {
                _ctx.records.Remove(rec);
                return true;
            }
            return false;
        }

        public Record GetRecord(string id)
        {
            var rec = _ctx.records.FirstOrDefault(x => x.id == id);
            if (rec != null)
            {
                return rec;
            }
            return null;
        }

        public List<Record> GetRecords()
        {
            return _ctx.records.ToList();
        }
    }
}
