using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyStoreMangement
{
   
    public partial class Member : Form
    {

        private SignIn F2 { get; set; }

        public Member(SignIn f2)
        {
            InitializeComponent();
            this.F2 = f2;
            PgInvoices invoices = new PgInvoices();
            AddUserControl(invoices);

        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlPgMember.Controls.Clear();
            pnlPgMember.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void moveImageBox(object sender)
        {
            GunaAdvenceButton btn = (GunaAdvenceButton)sender;
            imgSlide.Location = new Point(btn.Location.X + 80, btn.Location.Y - 36);
            imgSlide.SendToBack();
        }
        private void BtnInvoices_Click(object sender, EventArgs e)
        {
            PgInvoices invoices = new PgInvoices();
            AddUserControl(invoices);
        }
        private void BtnDrugInfo_Click(object sender, EventArgs e)
        {
            PgDrugInfo drugifo = new PgDrugInfo();
            AddUserControl(drugifo);
        }
        private void gunaAdvenceButton2_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Complete.");
            this.Hide();
            this.F2.Show();
        }
    }
}
