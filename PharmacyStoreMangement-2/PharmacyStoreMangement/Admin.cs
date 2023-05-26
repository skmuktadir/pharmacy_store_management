using Guna.UI.WinForms;
using Guna.UI2.WinForms;
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
    public partial class FormAdmin : Form
    {
        private SignIn F2 { get; set; }
        public FormAdmin(SignIn f2)
        {
            this.F2 = f2;
            InitializeComponent();
            PgOverview overview = new PgOverview();
            AddUserControl(overview);
        }
        private void moveImageBox(object sender)
        {
            GunaAdvenceButton btn = (GunaAdvenceButton)sender;
            imgSlide.Location = new Point(btn.Location.X + 108, btn.Location.Y - 25);
            imgSlide.SendToBack();
        }

        private void gunaAdvenceButton1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

       private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlAdmin.Controls.Clear();
            pnlAdmin.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Complete.");
            this.Hide();
            this.F2.Show();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            PgOverview overview = new PgOverview();
            AddUserControl(overview);
        }

        private void BtnMedicines_Click(object sender, EventArgs e)
        {
            PgMedicine medicine = new PgMedicine();
            AddUserControl(medicine);
        }

        private void BtnSalesPerson_Click(object sender, EventArgs e)
        {
            PgEmployees employees = new PgEmployees();
            AddUserControl(employees);
        }

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            PgTransactionscs overview = new PgTransactionscs();
            AddUserControl(overview);
        }
    }
    }

