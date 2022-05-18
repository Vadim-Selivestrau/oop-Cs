using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class LoginForm : Form
    {
        AppContext db = new AppContext();
        private LoginPresenter lp;
        public LoginForm()
        {
            InitializeComponent();
            lp = new LoginPresenter(this, new LoginModel());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp();
            Hide();
            signUpForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = nameTextBox.Text;
            string password = passwordTextBox.Text;
            if (nameTextBox.Text.Trim() == string.Empty)
            {
                nameTextBox.BackColor = System.Drawing.Color.Red;
            }
            else if (passwordTextBox.Text.Trim() == string.Empty)
            {
                passwordTextBox.BackColor = System.Drawing.Color.Red;
                passwordTextBox.Text = string.Empty;
            }
            else
            {
                Hide();
                lp.ValidEnter(nameTextBox.Text.Trim(), passwordTextBox.Text.Trim());
            }
        }


        public void Continue(Form form)
        {
            form.Show();
        }
    }
}
