using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    class RequestField
    {
        public Panel FieldPanel { get; set; }
        public Button AproveButton { get; set; }
        public Button DeniedButton { get; set; }
        public Label UserInfo { get; set; }
        public Client Client { get; set; }
        public TableLayoutPanel TablePanel { get; set; }

        public RequestField(Client client, TableLayoutPanel tablePanel)
        {
            TablePanel = tablePanel;
            Client = client;
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

            UserInfo = new Label();
            UserInfo.ForeColor = Color.Black;
            UserInfo.Dock = DockStyle.Fill;
            UserInfo.TextAlign = ContentAlignment.MiddleCenter;
            UserInfo.Text = $"Name: {Client.Name} | L.Name: {Client.SurName} | Passp.numb.: {Client.PassportNumber} | ID: {Client.Login}";
           
            FieldPanel.Controls.Add(AproveButton);
            FieldPanel.Controls.Add(DeniedButton);
            FieldPanel.Controls.Add(UserInfo);

            DeniedButton.Click += DeniedButton_Click;
            AproveButton.Click += AproveButton_Click;
        }

        private void AproveButton_Click(object sender, EventArgs e)
        {
            TablePanel.Controls.Remove(FieldPanel);
            AppContext db = new AppContext();
            Client.Confirmed = true;
            db.Update(Client);
            db.SaveChanges();
        }

        private void DeniedButton_Click(object sender, EventArgs e)
        {
            TablePanel.Controls.Remove(FieldPanel);
            AppContext db = new AppContext();
            db.Clients.Remove(Client);
            db.SaveChanges();
        }
    }
}
