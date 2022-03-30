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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passwordInvisiblebutton.Visible = false;
        }


       

        private void passwordField_Load(object sender, EventArgs e)
        {
            
            loginField.MaxLength = 15;
            passwordField.MaxLength = 20;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordVisibleButton_Click(object sender, EventArgs e)
        {
            passwordField.UseSystemPasswordChar = false;
            passwordInvisiblebutton.Visible = true;
            passwordVisibleButton.Visible = false;
        }

        private void passwordInvisiblebutton_Click(object sender, EventArgs e)
        {
            passwordField.UseSystemPasswordChar = true;
            passwordInvisiblebutton.Visible = false;
            passwordVisibleButton.Visible = true;
        }

        private void registrationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            Hide();
            signUpForm.ShowDialog();
            
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
