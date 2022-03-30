namespace lab1
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passportNumberTextBox = new System.Windows.Forms.TextBox();
            this.passportSeriesTextBox = new System.Windows.Forms.TextBox();
            this.citizenshipComboBox = new System.Windows.Forms.ComboBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.passportSeriesLabel = new System.Windows.Forms.Label();
            this.passportNumberLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.citizenshipLabel = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backLabel = new System.Windows.Forms.Label();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(207, 194);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(154, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(207, 243);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(154, 20);
            this.surnameTextBox.TabIndex = 1;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(207, 289);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(154, 20);
            this.patronymicTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(207, 353);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(154, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // passportNumberTextBox
            // 
            this.passportNumberTextBox.Location = new System.Drawing.Point(583, 243);
            this.passportNumberTextBox.MaxLength = 2;
            this.passportNumberTextBox.Name = "passportNumberTextBox";
            this.passportNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.passportNumberTextBox.TabIndex = 6;
            // 
            // passportSeriesTextBox
            // 
            this.passportSeriesTextBox.Location = new System.Drawing.Point(583, 194);
            this.passportSeriesTextBox.Name = "passportSeriesTextBox";
            this.passportSeriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.passportSeriesTextBox.TabIndex = 7;
            // 
            // citizenshipComboBox
            // 
            this.citizenshipComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citizenshipComboBox.FormattingEnabled = true;
            this.citizenshipComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.citizenshipComboBox.Items.AddRange(new object[] {
            "Belarus",
            "foreigner"});
            this.citizenshipComboBox.Location = new System.Drawing.Point(583, 352);
            this.citizenshipComboBox.Name = "citizenshipComboBox";
            this.citizenshipComboBox.Size = new System.Drawing.Size(100, 21);
            this.citizenshipComboBox.TabIndex = 9;
            this.citizenshipComboBox.SelectedIndexChanged += new System.EventHandler(this.citizenshipComboBox_SelectedIndexChanged);
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(364, 444);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(156, 47);
            this.registrationButton.TabIndex = 10;
            this.registrationButton.Text = "Sign Up";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(166, 197);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(152, 246);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 12;
            this.surnameLabel.Text = "Surname";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(142, 292);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(59, 13);
            this.patronymicLabel.TabIndex = 13;
            this.patronymicLabel.Text = "Patronymic";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(169, 356);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(32, 13);
            this.Emaillabel.TabIndex = 14;
            this.Emaillabel.Text = "Email";
            // 
            // passportSeriesLabel
            // 
            this.passportSeriesLabel.AutoSize = true;
            this.passportSeriesLabel.Location = new System.Drawing.Point(502, 197);
            this.passportSeriesLabel.Name = "passportSeriesLabel";
            this.passportSeriesLabel.Size = new System.Drawing.Size(75, 13);
            this.passportSeriesLabel.TabIndex = 15;
            this.passportSeriesLabel.Text = "Passport seies";
            // 
            // passportNumberLabel
            // 
            this.passportNumberLabel.AutoSize = true;
            this.passportNumberLabel.Location = new System.Drawing.Point(491, 246);
            this.passportNumberLabel.Name = "passportNumberLabel";
            this.passportNumberLabel.Size = new System.Drawing.Size(86, 13);
            this.passportNumberLabel.TabIndex = 16;
            this.passportNumberLabel.Text = "Passport number";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(519, 292);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(58, 13);
            this.telephoneLabel.TabIndex = 17;
            this.telephoneLabel.Text = "Telephone";
            // 
            // citizenshipLabel
            // 
            this.citizenshipLabel.AutoSize = true;
            this.citizenshipLabel.Location = new System.Drawing.Point(519, 356);
            this.citizenshipLabel.Name = "citizenshipLabel";
            this.citizenshipLabel.Size = new System.Drawing.Size(57, 13);
            this.citizenshipLabel.TabIndex = 18;
            this.citizenshipLabel.Text = "Citizenship";
            // 
            // roleComboBox
            // 
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.roleComboBox.Items.AddRange(new object[] {
            "Client",
            "Operator",
            "Manager",
            "Company Specialist"});
            this.roleComboBox.Location = new System.Drawing.Point(583, 401);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(100, 21);
            this.roleComboBox.TabIndex = 19;
            this.roleComboBox.SelectedIndexChanged += new System.EventHandler(this.roleComboBox_SelectedIndexChanged);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(548, 404);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(29, 13);
            this.roleLabel.TabIndex = 20;
            this.roleLabel.Text = "Role";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.backLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 164);
            this.panel1.TabIndex = 21;
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backLabel.Location = new System.Drawing.Point(12, 9);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(18, 13);
            this.backLabel.TabIndex = 2;
            this.backLabel.Text = "←";
            this.backLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(583, 289);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telephoneTextBox.TabIndex = 5;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.citizenshipLabel);
            this.Controls.Add(this.telephoneLabel);
            this.Controls.Add(this.passportNumberLabel);
            this.Controls.Add(this.passportSeriesLabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.citizenshipComboBox);
            this.Controls.Add(this.passportSeriesTextBox);
            this.Controls.Add(this.passportNumberTextBox);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passportNumberTextBox;
        private System.Windows.Forms.TextBox passportSeriesTextBox;
        private System.Windows.Forms.ComboBox citizenshipComboBox;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label passportSeriesLabel;
        private System.Windows.Forms.Label passportNumberLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label citizenshipLabel;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.TextBox telephoneTextBox;
    }
}