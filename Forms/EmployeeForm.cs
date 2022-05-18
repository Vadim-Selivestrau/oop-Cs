using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    public partial class EmployeeForm : Form
    {
        private EmployeePresenter ep;
        Employee employee { get; set; }
        public EmployeeForm(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            ep = new EmployeePresenter(this, new EmployeeModel());
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using AppContext db = new AppContext();
            if (textBox1.Text.Trim().Length == 0)
            {
                //unp messagebox can't be empty
            }
            else if (textBox2.Text.Trim().Length == 0)
            {
                //name company messagebox can't be empty
            }
            else if (textBox3.Text.Trim().Length == 0)
            {
                // addres messagebox can't be empty
            }
            else if (!db.Companies.Any(c => c.UNP == textBox1.Text.Trim()))
            {
                Random rd = new Random();
                Company company = new Company
                {
                    UNP = textBox1.Text.Trim(),
                    BID = bankComboBox.Text,
                    Name = textBox2.Text,
                    Address = textBox3.Text,
                    Confirmed = false,
                    Requested = false,
                    Money = rd.Next(25000, 70000),
                };

                employee.UNP = company.UNP;

                db.Employees.Update(employee);
                db.Companies.Add(company);
                db.SaveChanges();

                InitializeSP();
            }
        }
        private void InitializeSP()
        {
            using AppContext db = new AppContext();
            List<string> Banks = new List<string>();
            foreach (Bank b in db.Banks.ToList())
            {
                Banks.Add(b.BID);
            }

            typeCompanyComboBox.SelectedIndex = 0;
            bankComboBox.Items.AddRange(Banks.ToArray());
            bankComboBox.SelectedIndex = 0;

            if (employee.UNP != null)
            {
                registrCompanyButton.Enabled = false;
                billTextBox.Enabled = true;

                Company Company = db.Companies
                    .FirstOrDefault(c => c.UNP == employee.UNP);
                if (Company.Confirmed || Company.Requested)
                {
                    requestButton.Enabled = false;
                }
            }
            else
            {
                billTextBox.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using AppContext db = new AppContext();
            if (db.Bills.Any(b => b.BillNumber == billTextBox.Text))
            {
                Company Company = db.Companies
                    .Include(c => c.BillsNSalaries)
                    .FirstOrDefault(c => c.UNP == employee.UNP);
                if (Company.BillsNSalaries.Any(b => b.BillNumber == billTextBox.Text))
                {
                    BillsNSalary billsNSalary = Company.BillsNSalaries.FirstOrDefault(b => b.BillNumber == billTextBox.Text);
                    billsNSalary.Salary = (int)numericUpDown1.Value;
                    statusLabel.Text = $"Changed salary for\n{billTextBox.Text}";
                }
                else
                {
                    Company.AddWorker(billTextBox.Text, (int)numericUpDown1.Value);
                    statusLabel.Text = "Succesfull";
                }

                db.Employees.Update(employee);
                db.Companies.Update(Company);
                db.SaveChanges();
            }
            else
            {
                statusLabel.Text = "No such bill";
            }
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            using AppContext db = new AppContext();
            Company Company = db.Companies
                .FirstOrDefault(c => c.UNP == employee.UNP);
            Company.Requested = true;
            db.Employees.Update(employee);
            db.SaveChanges();
            requestButton.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using AppContext db = new AppContext();
            if (unpTextBox.Text.Trim().Length == 0)
            {
                labelInfo.Text = "UNP is empty";
            }
            else
            {
                if (db.Companies.Any(c => c.Confirmed && c.UNP == unpTextBox.Text.Trim()))
                {
                    Company Company = db.Companies
                        .Include(c => c.BillsNSalaries)
                        .FirstOrDefault(c => c.UNP == unpTextBox.Text.Trim());
                    if (Company.BillsNSalaries
                        .Any(b => b.BillNumber == salaryBillTextBox.Text))
                    {
                        BillsNSalary billsNSalary = new BillsNSalary
                        {
                            IsRequest = true,
                            BillNumber = salaryBillTextBox.Text,
                            Salary = (int)numericUpDown2.Value,
                            FromBill = employee.UNP,
                        };
                        Company.BillsNSalaries.Add(billsNSalary);
                        db.BillsNSalaries.Add(billsNSalary);
                        labelInfo.Text = "Succesful";
                    }
                    else if (salaryBillTextBox.Text.Length == 0)
                    {
                        BillsNSalary billsNSalary = new BillsNSalary
                        {
                            IsRequest = true,
                            BillNumber = unpTextBox.Text.Trim(),
                            Salary = (int)numericUpDown2.Value,
                            FromBill = employee.UNP,
                        };
                        Company.BillsNSalaries.Add(billsNSalary);
                        db.BillsNSalaries.Add(billsNSalary);
                        labelInfo.Text = "Succesful";
                    }
                    else
                    {
                        labelInfo.Text = "No such bill";
                    }

                    db.Companies.Update(Company);
                    db.SaveChanges();
                }
                else
                {
                    labelInfo.Text = "No such company";
                }
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            InitializeSP();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
