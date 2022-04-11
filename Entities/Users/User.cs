using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    abstract class User
    {
        PassportData passportData;
        Citizenship citizenship;
        ConnectData connectData;
        string login;
        string password;

        public User(PassportData PASSPORTDATA, Citizenship CITIZENSHIP, ConnectData CONNECTDATA, string LOGIN, string PASSWORD)
        {
            passportData = PASSPORTDATA;
            citizenship = CITIZENSHIP;
            connectData = CONNECTDATA;
            login = LOGIN;
            password = PASSWORD;
        }
    }
}
