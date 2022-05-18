using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    public class SalaryPRequest
    {
        public Panel FieldPanel { get; set; }
        public Button AproveButton { get; set; }
        public Button DeniedButton { get; set; }
        public Label CompanyInfo { get; set; }
        public Company Company { get; set; }
        public Employee Employee{ get; set; }
        public TableLayoutPanel TablePanel { get; set; }

        public SalaryPRequest(Company company, Employee employee, TableLayoutPanel tablePanel)
        {
            TablePanel = tablePanel;
            Company = company;
            Employee = employee;
            FieldPanel = new Panel();
            FieldPanel.Size = new Size(600, 50);
            FieldPanel.Dock = DockStyle.Top;
            FieldPanel.BorderStyle = BorderStyle.Fixed3D;
            FieldPanel.Margin = new Padding(3, 3, 3, 0);

            AproveButton = new Button();
            AproveButton.Size = new Size(80, 50);
            AproveButton.TextAlign = ContentAlignment.MiddleCenter;
            AproveButton.Dock = DockStyle.Left;
            AproveButton.Text = "Aprove";

            DeniedButton = new Button();
            DeniedButton.Size = new Size(80, 50);
            DeniedButton.TextAlign = ContentAlignment.MiddleCenter;
            DeniedButton.Dock = DockStyle.Left;
            DeniedButton.Text = "Denied";

            CompanyInfo = new Label();
            CompanyInfo.ForeColor = Color.Black;
            CompanyInfo.Dock = DockStyle.Fill;
            CompanyInfo.TextAlign = ContentAlignment.MiddleCenter;
            CompanyInfo.Text = $"Name: {Company.Name} | UNP: {Company.UNP} | Address: {Company.Address}";

            FieldPanel.Controls.Add(AproveButton);
            FieldPanel.Controls.Add(DeniedButton);
            FieldPanel.Controls.Add(CompanyInfo);

            DeniedButton.Click += DeniedButton_Click;
            AproveButton.Click += AproveButton_Click;
        }

        private void AproveButton_Click(object sender, EventArgs e)
        {
            TablePanel.Controls.Remove(FieldPanel);
            AppContext db = new AppContext();
            Company.Confirmed = true;
            Company.Requested = false;
            db.Companies.Update(Company);
            db.SaveChanges();
        }

        private void DeniedButton_Click(object sender, EventArgs e)
        {
            TablePanel.Controls.Remove(FieldPanel);
            AppContext db = new AppContext();
            db.Companies.Remove(Company);
            Employee.UNP = null;
            db.Employees.Update(Employee);
            db.SaveChanges();
        }
    }
}
