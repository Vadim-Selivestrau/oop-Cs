using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }


        private void citizenshipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {

            if (nameTextBox.Text == "" || surnameTextBox.Text == ""
                || patronymicTextBox.Text == "" || emailTextBox.Text == ""
                || passportNumberTextBox.Text == "" || passportSeriesTextBox.Text == ""
                || telephoneTextBox.Text.Length != 7 || citizenshipComboBox.Text == ""
                || roleComboBox.Text == "")
            {
                MessageBox.Show("ты пидор");
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                Hide();
                loginForm.ShowDialog();
            }        
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.ShowDialog();
        }
    }
}
