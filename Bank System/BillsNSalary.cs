using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1
{
    public class BillsNSalary
    {
        public int Id { get; set; }
        public string BillNumber { get; set; }
        public int Salary { get; set; }
        public bool IsRequest { get; set; }
        public string FromBill { get; set; }
    }
}
