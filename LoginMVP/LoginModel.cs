using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    public class LoginModel
    {
        public Form form;
        private AppContext db = new AppContext();
        public Form ValidEnter(string login, string password)
        {
            using AppContext db = new AppContext();

            if (db.Clients.Any(c => c.Login == login && c.Password == password))
            {
                if (db.Clients.Any(c => c.Confirmed == false))
                {
                    MessageBox.Show("your account not confirmed");
                    /*your account is under review*/
                    form = new LoginForm();
                    return form;
                }

                Client client = db.Clients.FirstOrDefault(c => c.Login == login && c.Password == password);
                //create a window
                Client newUser = db.Clients
                    .Include(c => c.Bills)
                    .ThenInclude(b => b.Credits)
                    .Include(c => c.Bills)
                    .ThenInclude(b => b.Installements)
                    .Include(c => c.Bills)
                    .ThenInclude(b => b.Transactions)
                    .ToList()
                    .Find(u => u.Login == login.Trim() && u.Password == password.Trim());


                form = new ClientForm(client);
            }
            else if (db.Manager.Any(m => m.Login == login && m.Password == password))
            {
                Manager manager = db.Manager.FirstOrDefault(m => m.Login == login && m.Password == password);
                //create a window

                form = new ManagerForm(manager);
            }
            else if(db.Employees.Any(m => m.Login == login && m.Password == password))
            {
                Employee employee = db.Employees.FirstOrDefault(m => m.Login == login && m.Password == password);

                form = new EmployeeForm(employee);
            }
            else
            {
                MessageBox.Show("error try again");
                form = new LoginForm();
            }
            
            return form;
        }
        
    }
}
