using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    class RegistrationPresenter
    {
        public SignUp view;
        public RegistrationModel model;

        public void SignUp(string login, string password, string name, string surName, string patronymic, string passportSeries, string passportNumber, string phone, string mail, string citizenship, int role, Bank bank)
        {
            model.SignUp(login, password, name, surName, patronymic, passportSeries, passportNumber, phone, mail, citizenship, role, bank);
        }

        public void LoginCheck(string login, int role)
        {
            if (!(model.LoginCheck(login, role)))
            {
                view.LoginCheckFailed();
            }
        }
        public Bank FindBank(string info)
        {
            return model.FindBank(info);
        }
    }
}
