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
    public partial class SignUp : Form
    {
        private RegistrationPresenter rp;

        public bool mistake;
        public SignUp()
        {
            rp = new RegistrationPresenter()
            {
                view = this, 
                model = new RegistrationModel()
            };
            InitializeComponent();

        }


        public void LoginCheckFailed()
        {
            MessageBox.Show("this login is busy");
            mistake = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (loginTextBox.Text.Trim() == string.Empty)
            {
                loginTextBox.BackColor = System.Drawing.Color.Red;
                mistake = true;
            }
            else
            {
                rp.LoginCheck(loginTextBox.Text, roleComboBox.SelectedIndex);
            }

            if (passwordTextBox.Text.Trim() == string.Empty)
            {
                passwordTextBox.BackColor = System.Drawing.Color.Red;
                mistake = true;
            }

            if (nameTextBox.Text.Trim() == string.Empty)
            {
                nameTextBox.BackColor = System.Drawing.Color.Red;
                mistake = true;
            }

            if (middleNameTextBox.Text.Trim() == string.Empty)
            {
                middleNameTextBox.BackColor = System.Drawing.Color.Red;
                mistake = true;
            }

            if (patronymicTextBox.Text.Trim() == string.Empty)
            {
                patronymicTextBox.BackColor = System.Drawing.Color.Red;
                mistake = true;
            }
            if (passportSeriesTextBox.Text.Trim() == string.Empty)
            {
                passportSeriesTextBox.BackColor = System.Drawing.Color.Red;
                mistake = true;
            }

            if (passportNumberTextBox.Text.Trim() == string.Empty)
            {
                passportNumberTextBox.BackColor = System.Drawing.Color.Red;
                mistake = true;
            }

            if (phoneTextBox.Text.Trim() == string.Empty)
            {
                phoneTextBox.BackColor = System.Drawing.Color.Red;
                mistake = true;
            }

            if (mailTextBox.Text.Trim() == string.Empty)
            {
                mailTextBox.BackColor = System.Drawing.Color.Red;
                mistake = true;
            }

            Bank bank = new Bank();
            if (bankComboBox.SelectedIndex > 0)
            {
                bank = rp.FindBank(bankComboBox.Text.Trim());
            }

            if (!mistake)
            {

                rp.SignUp(loginTextBox.Text, passwordTextBox.Text, nameTextBox.Text, middleNameTextBox.Text, patronymicTextBox.Text, passportSeriesTextBox.Text, passportNumberTextBox.Text,
                    phoneTextBox.Text, mailTextBox.Text, citizensipComboBox.SelectedIndex.ToString(), roleComboBox.SelectedIndex, bank);

                MessageBox.Show("Succes!");
                
                LoginForm loginForm = new LoginForm();
                Hide();
                loginForm.ShowDialog();
            }
                 
            
            /*User a = new User
            {
                Name = "vadim",
            };*/
            //db.Users.Add(a);
            
        }


        private void SignUp_Load(object sender, EventArgs e)
        {
            roleComboBox.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.ShowDialog();
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleComboBox.SelectedIndex > 0)
            {
                using AppContext db = new AppContext();
                bankComboBox.Visible = true;
                List<string> Banks = new List<string>();
                foreach (Bank b in db.Banks.ToList())
                {
                    Banks.Add(b.Name + "//" + b.BID);
                }

                bankComboBox.Items.AddRange(Banks.ToArray()); //db.Banks.ToArray().ToString()
                bankComboBox.SelectedIndex = 0;
            }
            else
            {
                bankComboBox.Visible = false;
            }
        }
    }
}
