using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    public class User
    {
        public User(string login, string password, string name, string surName, string patronymic, string passportSeries, string passportNumber, string phone, string mail, string citizenship)
        {
            Login = login;
            Password = password;
            Name = name;
            SurName = surName;
            Patronymic = patronymic;
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            Phone = phone;
            Mail = mail;
            Citizenship = citizenship;
        }
        public User()
        {

        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Citizenship { get; set; }
        public bool Confirmed { get; set; }
    }
}
