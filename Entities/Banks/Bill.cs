using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Bill
    {
        public int Id { get; set; }
        public string BID { get; set; }
        public double Money { get; set; }
        public string BillNumber { get; set; }
        public bool Blocked { get; set; }
        public bool Freezed { get; set; }
    }
}
