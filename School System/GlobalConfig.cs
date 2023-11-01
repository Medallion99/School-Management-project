using School_System.Logic;
using School_System.Logic.Interface;
using SchoolSystem.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    public static class GlobalConfig
    {
        public static IRecordLogic _recordLogic;
        public static IStudentLogic _studentLogic;

        public static void Initiate()
        {
            var ctx = new Context();
            _recordLogic = new RecordLogic(ctx);
            _studentLogic = new StudentLogic(ctx);
        }
    }
}
