namespace lab1
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.autorisa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registrationLabel = new System.Windows.Forms.LinkLabel();
            this.passwordInvisiblebutton = new System.Windows.Forms.PictureBox();
            this.passwordVisibleButton = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordInvisiblebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordVisibleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.autorisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 164);
            this.panel1.TabIndex = 1;
            // 
            // autorisa
            // 
            this.autorisa.AutoSize = true;
            this.autorisa.Location = new System.Drawing.Point(378, 55);
            this.autorisa.Name = "autorisa";
            this.autorisa.Size = new System.Drawing.Size(88, 13);
            this.autorisa.TabIndex = 0;
            this.autorisa.Text = "AUTORISATION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.registrationLabel);
            this.panel2.Controls.Add(this.passwordInvisiblebutton);
            this.panel2.Controls.Add(this.passwordVisibleButton);
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Controls.Add(this.passwordField);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.loginField);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 372);
            this.panel2.TabIndex = 2;
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.LinkColor = System.Drawing.SystemColors.GrayText;
            this.registrationLabel.Location = new System.Drawing.Point(378, 350);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(81, 13);
            this.registrationLabel.TabIndex = 7;
            this.registrationLabel.TabStop = true;
            this.registrationLabel.Text = "Create Account";
            this.registrationLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrationLabel_LinkClicked);
            // 
            // passwordInvisiblebutton
            // 
            this.passwordInvisiblebutton.Image = ((System.Drawing.Image)(resources.GetObject("passwordInvisiblebutton.Image")));
            this.passwordInvisiblebutton.Location = new System.Drawing.Point(569, 214);
            this.passwordInvisiblebutton.Name = "passwordInvisiblebutton";
            this.passwordInvisiblebutton.Size = new System.Drawing.Size(30, 30);
            this.passwordInvisiblebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordInvisiblebutton.TabIndex = 6;
            this.passwordInvisiblebutton.TabStop = false;
            this.passwordInvisiblebutton.Click += new System.EventHandler(this.passwordInvisiblebutton_Click);
            // 
            // passwordVisibleButton
            // 
            this.passwordVisibleButton.Image = ((System.Drawing.Image)(resources.GetObject("passwordVisibleButton.Image")));
            this.passwordVisibleButton.Location = new System.Drawing.Point(569, 214);
            this.passwordVisibleButton.Name = "passwordVisibleButton";
            this.passwordVisibleButton.Size = new System.Drawing.Size(30, 30);
            this.passwordVisibleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordVisibleButton.TabIndex = 5;
            this.passwordVisibleButton.TabStop = false;
            this.passwordVisibleButton.Click += new System.EventHandler(this.passwordVisibleButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(346, 289);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(157, 37);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(299, 214);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(264, 20);
            this.passwordField.TabIndex = 3;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(243, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(299, 80);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(264, 20);
            this.loginField.TabIndex = 1;
            this.loginField.TextChanged += new System.EventHandler(this.loginField_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordInvisiblebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordVisibleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label autorisa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox passwordInvisiblebutton;
        private System.Windows.Forms.PictureBox passwordVisibleButton;
        private System.Windows.Forms.LinkLabel registrationLabel;
    }
}

