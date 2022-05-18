using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1
{
    public class Client : User
    {
        
        public HashSet<Bill> Bills { get; set; }
        public Client()
        {

        }
        public void OpenBill(Bill bill)
        {
            AppContext db = new AppContext();
            Bills.Add(bill);
            db.Clients.Update(this);
            db.SaveChanges();
        }
    }
}
