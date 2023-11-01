using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Model
{
    public class BaseEntity
    {
        public string id { get; set; }
        public DateTime RegisteredOn { get; set; } = DateTime.Now;
        public DateTime DueOn { get; set; } = new DateTime();
    }
}
