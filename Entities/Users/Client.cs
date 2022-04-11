using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Client : User
    {
        BankAccount bankAccount;
        List<Bill> billList;
        public Client(PassportData PASSPORTDATA, Citizenship CITIZENSHIP, ConnectData CONNECTDATA, string LOGIN, string PASSWORD)
            :base(PASSPORTDATA, CITIZENSHIP, CONNECTDATA, LOGIN, PASSWORD)
        {

        }

    }
}
