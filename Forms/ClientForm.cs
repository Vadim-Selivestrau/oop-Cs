using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Laba1
{
    public partial class ClientForm : Form
    {
        private ClientPresenter cp;
        private AppContext db;
        
        public Client Client { get; set; }
        public ClientForm(Client client)
        {
            this.Client = client;
            InitializeComponent();

            cp = new ClientPresenter(this, new ClientModel());
        }
        
        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            InitializeMenu();
            InitializeDeals();
            Opportunity();
        }

        private void Opportunity()
        {
            
            periodComboBox.SelectedIndex = 0;
            BankInit();
            BillInit(Client);
        }
        private void BankInit()
        {
            List<string> Banks = cp.BankInit();

            bankComboBox.Items.Clear();
            bankComboBox.Items.AddRange(Banks.ToArray());
            bankComboBox.SelectedIndex = 0;

            accumulateComboBox.Items.Clear();
            accumulateComboBox.Items.AddRange(Banks.ToArray());
            accumulateComboBox.SelectedIndex = 0;
        }
        private void InitializeMenu()
        {
            Client = cp.ClientUpdate(Client);
            nameLabel.Text = Client.Name + " " + Client.Patronymic;
            middleNameLabel.Text = Client.SurName;
            moneyLabel.Text = Client.Bills.Sum(b => b.Money).ToString();
            tableLayoutPanelBill.Controls.Clear();
            tableLayoutPanelCredit.Controls.Clear();

            foreach (Bill bill in Client.Bills)
            {
                BillField billField = new BillField(bill, tableLayoutPanelBill);
                tableLayoutPanelBill.Controls.Add(billField.FieldPanel);

                foreach (Credit credit in bill.Credits)
                {
                    CreditField creditField = new CreditField(credit, bill, tableLayoutPanelCredit);
                    tableLayoutPanelCredit.Controls.Add(creditField.FieldPanel);
                }

                 foreach (Installement installement in bill.Installements)
                 {
                     CreditField creditField = new CreditField(installement, bill, tableLayoutPanelCredit);
                     tableLayoutPanelCredit.Controls.Add(creditField.FieldPanel);
                 }
            }

             if (Client.Bills.Count != 0)
             {
                 billsLabel.Text = "Bills";
             }
             else
             {
                 billsLabel.Text = "No Bills";
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           cp.CreateBill(Client, bankComboBox.Text.Trim(), billNumberLabel.Text);

            bankComboBox_SelectedIndexChanged(sender, e);
            InitializeMenu();
            InitializeDeals();
            BillInit(Client);
        }
        

        private void BillInit(Client client)
        {
            List<string> Bills = cp.BillInit(client);

            if (Bills.Count != 0)
            {
                creditComboBox.Enabled = true;
                creditButton.Enabled = true;
                periodComboBox.Enabled = true;
                numericUpDown1.Enabled = true;
                creditComboBox.Items.Clear();
                creditComboBox.Items.AddRange(Bills.ToArray());
                creditComboBox.SelectedIndex = 0;

                transferPanel.Enabled = true;
                accumulatePanel.Enabled = true;
                freezePanel.Enabled = true;
                billСomboBox.Items.Clear();
                billСomboBox.Items.AddRange(Bills.ToArray());
                billСomboBox.SelectedIndex = 0;
            }
            else
            {
                creditComboBox.Enabled = false;
                creditButton.Enabled = false;
                periodComboBox.Enabled = false;
                numericUpDown1.Enabled = false;

                transferPanel.Enabled = false;
                accumulatePanel.Enabled = false;
                freezePanel.Enabled = false;
            }
        }


        private void InitializeDeals()
        {
            label13.Text = transferMoneyNumericUpDown.Value.ToString();
            label17.Text = transferMoneyNumericUpDown.Value.ToString();

            using AppContext db = new AppContext();
            List<string> Bills = new List<string>();
            foreach (Bill bill in Client.Bills)
            {
                Bills.Add(bill.BillNumber);
            }

            if (Bills.Count != 0)
            {
                freezeComboBox.Enabled = true;
                freezeButton.Enabled = true;
                freezeComboBox.Items.Clear();
                freezeComboBox.Items.AddRange(Bills.ToArray());
                freezeComboBox.SelectedIndex = 0;
            }
            else
            {
                freezeComboBox.Enabled = false;
                freezeButton.Enabled = false;
            }
        }

        private void bankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] BankAndBID = Regex.Split(bankComboBox.Text.Trim(), "//");
            string bn = cp.BankIndex(bankComboBox.Text.Trim());

            bankNameLabel.Text = BankAndBID[0];
            billNumberLabel.Text = bn;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using AppContext db = new AppContext();
            if (db.Bills.Any(b => b.BillNumber == transferBillTextBox.Text))
            {
                Bill SourceBill = db.Bills
                    .Include(b => b.Transactions)
                    .FirstOrDefault(b => b.BillNumber == billСomboBox.Text);
                if (SourceBill.Money >= (double)transferMoneyNumericUpDown.Value)
                {
                    SourceBill.Money -= (double)transferMoneyNumericUpDown.Value;
                    Bill DestBill = db.Bills.Include(b => b.Transactions).FirstOrDefault(b => b.BillNumber == transferBillTextBox.Text);
                    DestBill.Money += (double)transferMoneyNumericUpDown.Value;
                    Transaction tr = new Transaction()
                    {
                        DestBill = DestBill.BillNumber,
                        Amount = (double)transferMoneyNumericUpDown.Value,
                    };

                    SourceBill.Transactions.Add(tr);    
                    db.Transactions.Add(tr);
                    db.Bills.Update(SourceBill);
                    db.Bills.Update(DestBill);
                    db.SaveChanges();
                    InitializeMenu();
                }
                else
                {
                    //messageboxlowmoney
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using AppContext db = new AppContext();
            Bill SourceBill = db.Bills.FirstOrDefault(b => b.BillNumber == billСomboBox.Text);

            if (!SourceBill.Freezed)
            {
                if (SourceBill.Money >= (double)accumulateNumericUpDown.Value)
                {
                    string[] BankAndBID = Regex.Split(accumulateComboBox.Text.Trim(), "//");
                    Bank bank = db.Banks.Include(b => b.ClientAccum).FirstOrDefault(b => b.BID == BankAndBID[1]);
                    SourceBill.Money -= (double)accumulateNumericUpDown.Value;
                    Accumulate accum = new Accumulate
                    {
                        ClientId = Client.Login,
                        Amount = (double)accumulateNumericUpDown.Value,
                        Percent = bank.AccumPercent,
                        Time = DateTime.UtcNow,
                    };
                    bank.ClientAccum.Add(accum);
                    db.Banks.Update(bank);
                    db.Accumulates.Add(accum);
                    db.SaveChanges();
                    InitializeMenu();

                }
                else
                {
                    //messagebox low money
                }
            }
            else
            {
                //MessageBox bill is freezed
            }
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            using AppContext db = new AppContext();
            string BillNumber = creditComboBox.Text;
            Bill bill = Client.Bills.FirstOrDefault(b => b.BillNumber == BillNumber);

            if (radioButton1.Checked)
            {
                Credit credit = new Credit
                {
                    Confirmed = false,
                    Months = Convert.ToInt32(periodComboBox.Text),
                    Money = (double)numericUpDown1.Value,
                    Percent = db.Banks.FirstOrDefault(b => b.BID == bill.BID).OverPaymentPercent,
                };

                bill.CreditRequest(credit);
            }
            else if(radioButton2.Checked)
            {
                Installement installement = new Installement
                {
                    Confirmed = false,
                    Months = Convert.ToInt32(periodComboBox.Text),
                    Money = (double)numericUpDown1.Value,
                };

                bill.InstallmentRequest(installement);
            }
            else
            {
                //messagebox installement or credit
            }

            InitializeMenu();
        }

        private void freezeButton_Click(object sender, EventArgs e)
        {
            using AppContext db = new AppContext();
            Bill bill;
            string BillNumber = freezeComboBox.Text;
            bill = db.Bills.FirstOrDefault(b => b.BillNumber == BillNumber);

            if (freezeButton.Text == "Freeze")
            {
                bill.Freezed = true;
            }
            else
            {
                bill.Freezed = false;
            }

            db.Bills.Update(bill);
            db.SaveChanges();
            freezeComboBox_SelectedIndexChanged(sender, e);
            BillInit(Client);
            InitializeMenu();
        }

        private void freezeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using AppContext db = new AppContext();
            Bill bill;
            string BillNumber = freezeComboBox.Text;
            bill = db.Bills.FirstOrDefault(b => b.BillNumber == BillNumber);

            if (bill.Blocked)
            {
                infoFreezeLabel.Text = "Already blocked";
                freezeButton.Visible = false;
            }
            else if (bill.Freezed)
            {
                infoFreezeLabel.Text = "Already freezed";
                freezeButton.Visible = true;
                freezeButton.Text = "Unfreeze";
            }
            else
            {
                infoFreezeLabel.Text = "Freeze you can cancel\nBlocking you cann't";
                freezeButton.Visible = true;
                freezeButton.Text = "Freeze";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.ShowDialog();
        }
    }
}
