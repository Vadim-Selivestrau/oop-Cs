using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Laba1
{
    public class ClientModel
    {
        private AppContext db;
        public ClientModel()
        {
            db = new AppContext();
        }

        public List<string> BankInit()
        {
            List<string> Banks = new List<string>();
            foreach (Bank b in db.Banks.ToList())
            {
                Banks.Add(b.Name + "//" + b.BID);
            }

            return Banks;
        }

        public Client ClientUpdate(Client client)
        {
            client = db.Clients
                .Include(c => c.Bills)
                .ThenInclude(b => b.Credits)
                .Include(c => c.Bills)
                .ThenInclude(b => b.Installements)
                .Include(c => c.Bills)
                .FirstOrDefault(c => c.Id == client.Id);
            db.Clients.Update(client);
            db.SaveChanges();
            return client;
        }
        public string BankIndex(string bankNBID)
        {
            string[] BankAndBID = Regex.Split(bankNBID, "//");
            Bank bank = db.Banks.FirstOrDefault(b => b.Name == BankAndBID[0] && b.BID == BankAndBID[1]);

            Bill bill = new Bill()
            {
                BID = BankAndBID[1],
                Money = 0,
                Blocked = false,
                Freezed = false,
            };
            bill.BillInizializer(bank);

            return bill.BillNumber;
        }

        public void CreateBill(Client client, string bankNBID, string billNumber)
        {
            string[] BankAndBID = Regex.Split(bankNBID, "//");
            Bank bank = db.Banks
                .Include(b => b.Clients)
                .FirstOrDefault(b => b.Name == BankAndBID[0] && b.BID == BankAndBID[1]);

            if (!bank.Clients.Any(c => c.Id == client.Id))
            {
                bank.Clients.Add(client);
                db.Banks.Update(bank);
                db.SaveChanges();
            }

            Random rnd = new Random();
            Bill bill = new Bill()
            {
                BID = BankAndBID[1],
                Money = rnd.Next(1000, 6666),
                Blocked = false,
                Freezed = false,
                BillNumber = billNumber,
                Credits = new List<Credit>(),
                Installements = new List<Installement>(),
                Transactions = new List<Transaction>(),
            };

            client.OpenBill(bill);
            db.SaveChanges();
        }

        public List<string> BillInit(Client client)
        {
            List<string> Bills = new List<string>();
            foreach (Bill bill in client.Bills.Where(b => !b.Blocked && !b.Freezed))
            {
                Bills.Add(bill.BillNumber);
            }
            return Bills;
        }
    }
}
