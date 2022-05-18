using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    public class ManagerModel
    {
        private AppContext db;
        public ManagerModel()
        {
            db = new AppContext();
        }


        public List<Panel> Aprovement(string BID, TableLayoutPanel tb)
        {
            List<Panel> rf = new List<Panel>();
            foreach (Client client in db.Clients
                .Where(c => !c.Confirmed))
            {
                RequestField reqf = new RequestField(client, tb);
                rf.Add(reqf.FieldPanel);
            }

            return rf;
        }


        public List<Panel> InitializeCreditRequest(string BID, TableLayoutPanel tb)
        {
            List<Panel> rf = new List<Panel>();
            foreach (Client client in db.Clients
                .Include(c => c.Bills.Where(b => b.BID == BID))
                .ThenInclude(b => b.Credits)
                .Where(c => c.Bills.Sum(b => b.Credits.Count) != 0))
            {
                var credits = client.Bills
                .SelectMany(c => c.Credits)
                .Where(c => !c.Confirmed);

                foreach (Credit credit in credits)
                {
                    CreditRequest creditRequest = new CreditRequest(client, credit, tb);
                    rf.Add(creditRequest.FieldPanel);
                }
            }

            return rf;
        }

        public List<Panel> InitializeInstallementRequest(string BID, TableLayoutPanel tb)
        {
            List<Panel> rf = new List<Panel>();
            foreach (Client client in db.Clients
                .Include(c => c.Bills.Where(b => b.BID == BID))
                .ThenInclude(b => b.Installements)
                .Where(c => c.Bills.Sum(b => b.Installements.Count) != 0))
            {
                var installements = client.Bills
                .SelectMany(c => c.Installements)
                .Where(c => !c.Confirmed);

                foreach (Installement installement in installements)
                {
                    CreditRequest installementRequest = new CreditRequest(client, installement, tb);
                    rf.Add(installementRequest.FieldPanel);
                }
            }

            return rf;
        }
        public List<Panel> InitializeTransferRequest(Manager manager, TableLayoutPanel tb)
        {
            List<Panel> rf = new List<Panel>();
            Company company = db.Companies
                .Include(c => c.BillsNSalaries)
                .Include(c => c.CompanyTransfer)
                .FirstOrDefault(c => c.BID == manager.BID);

            foreach (BillsNSalary billsNSalary in company.BillsNSalaries.Where(b => b.IsRequest))
            {
                TransferRequest tReq = new TransferRequest(billsNSalary, company, tb);
                rf.Add(tReq.FieldPanel);
            }

            return rf;
        }
        public List<Panel> InitializeSPRequest(string BID, TableLayoutPanel tb)
        {
            List<Panel> rf = new List<Panel>();
            foreach (Employee employee in db.Employees)
            {
                if (db.Companies.Any(c => c.UNP == employee.UNP && c.Requested && c.BID == BID))
                {
                    Company company = db.Companies
                        .FirstOrDefault(c => c.UNP == employee.UNP && c.Requested);
                    SalaryPRequest salaryPRequest = new SalaryPRequest(company, employee, tb);
                    rf.Add(salaryPRequest.FieldPanel);
                }
            }

            return rf;
        }
    }
}
