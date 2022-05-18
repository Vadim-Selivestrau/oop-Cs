using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    public class EmployeeModel
    {
        private AppContext db;
        public EmployeeModel()
        {
            db = new AppContext();
        }
        
    }
}
