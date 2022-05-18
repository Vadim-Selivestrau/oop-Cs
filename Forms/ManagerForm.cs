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
    public partial class ManagerForm : Form
    {
        private ManagerPresenter mp;

        Manager Manager { get; set; }
        public ManagerForm(Manager manager)
        {
            this.Manager = manager;
            InitializeComponent();

            mp = new ManagerPresenter(this, new ManagerModel());
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            Aprovement(Manager.BID);
            InitializeTransferRequest();
        }




        private void Aprovement(string BID)
        {
            var reqF = mp.Aprovement(BID, clientApproveLayotPanel);
            clientApproveLayotPanel.Controls.AddRange(reqF.ToArray());

            InitializeCreditRequest(BID);
            InitializeInstallementRequest(BID);
            InitializeSPRequest(BID);
        }

        private void InitializeCreditRequest(string BID)
        {
            var reqCr = mp.InitializeCreditRequest(BID, approoveCreditTableLayoutPanel);
            approoveCreditTableLayoutPanel.Controls.AddRange(reqCr.ToArray());
        }
        private void InitializeInstallementRequest(string BID)
        {
            var reqIn = mp.InitializeInstallementRequest(BID, approoveInstallmentTableLayoutPanel);
            approoveInstallmentTableLayoutPanel.Controls.AddRange(reqIn.ToArray());
        }

        private void InitializeTransferRequest()
        {
            var reqT = mp.InitializeTransferRequest(Manager, salaryProjectTableLayoutPanel);
            salaryProjectTableLayoutPanel.Controls.AddRange(reqT.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.ShowDialog();
        }
        private void InitializeSPRequest(string BID)
        {
            var reqIn = mp.InitializeSPRequest(BID, salaryProjectTableLayoutPanel);
            salaryProjectTableLayoutPanel.Controls.AddRange(reqIn.ToArray());
        }


    }
}
