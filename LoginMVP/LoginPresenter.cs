using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    public class LoginPresenter
    {
        private readonly LoginForm View;
        private readonly LoginModel Model;

        /*public void SignUp(string login, string password, string name, string surName, string patronymic, string passportSeries, string passportNumber, string phone, string mail, string citizenship, int role)
        {
            model.SignUp(login,  password,  name,  surName,  patronymic,  passportSeries,  passportNumber,  phone,  mail,  citizenship, role);
        }*/

        public LoginPresenter(LoginForm view, LoginModel model)
        {
            View = view;
            Model = model;
        }
        public void ValidEnter(string login, string password)
        {
            Form form = Model.ValidEnter(login, password);
            View.Continue(form);
        }
    }
}
