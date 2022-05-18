using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Laba1
{
    class RegistrationModel
    {
        private readonly AppContext db = new AppContext();
        public void SignUp(string login, string password, string name, string surName, string patronymic, string passportSeries, string passportNumber, string phone, string mail, string citizenship, int rl, Bank bank)
        {
            User a = new User();
            switch (rl)
            {
                case 0:
                    Client client = new Client()
                    {
                        Login = login,
                        Password = password,
                        Name = name,
                        SurName = surName,
                        Patronymic = patronymic,
                        PassportSeries = passportSeries,
                        PassportNumber = passportNumber,
                        Phone = phone,
                        Mail = mail,
                        Citizenship = citizenship
                    };
                    db.Clients.Add(client);
                    break;
                case 1:
                    Manager manager = new Manager()
                    {
                        Login = login,
                        Password = password,
                        Name = name,
                        SurName = surName,
                        Patronymic = patronymic,
                        PassportSeries = passportSeries,
                        PassportNumber = passportNumber,
                        Phone = phone,
                        Mail = mail,
                        Citizenship = citizenship,
                        BID = bank.BID,
                        Confirmed = true
                    };
                    db.Manager.Add(manager);
                    break;
                case 2:
                    Employee employee = new Employee()
                    {
                        Login = login,
                        Password = password,
                        Name = name,
                        SurName = surName,
                        Patronymic = patronymic,
                        PassportSeries = passportSeries,
                        PassportNumber = passportNumber,
                        Phone = phone,
                        Mail = mail,
                        Citizenship = citizenship,
                        Confirmed = true
                    };
                    db.Employees.Add(employee);
                    break;
                default:
                    break;

            }
            db.SaveChanges();
        }

        public bool LoginCheck(string login, int role)
        {
            if (db.Clients.AsEnumerable().Any(u => u.Login == login) || db.Manager.AsEnumerable().Any(m => m.Login == login)
                || db.Employees.AsEnumerable().Any(e => e.Login == login))

            {
                return false;
            }
            else 
            { 
                return true; 
            }
            
        }

        public Bank FindBank(string info)
        {
            string[] BankAndBID = Regex.Split(info, "//");
            return db.Banks.AsEnumerable().ToList().Find(b => b.Name == BankAndBID[0] && b.BID == BankAndBID[1]);
        }

    }
}
