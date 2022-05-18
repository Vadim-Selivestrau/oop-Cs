using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    public class EmployeePresenter
    {
        private readonly EmployeeModel Model;
        private readonly EmployeeForm View;

        public EmployeePresenter(EmployeeForm view, EmployeeModel model)
        {
            Model = model;
            View = view;
        }
        

    }
}
