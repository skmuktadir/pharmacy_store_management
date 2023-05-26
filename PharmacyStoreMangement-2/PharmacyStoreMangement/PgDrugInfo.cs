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
    public partial class PgDrugInfo : UserControl
    {
        private DataAccess Da { get; set; }
        private void PopularGridView(string sql = @"select * from Medicine_Info")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvMedicineInfo.AutoGenerateColumns = false;
            this.dgvMedicineInfo.DataSource = ds;
        }
        public PgDrugInfo()
        {
            try
            {
                InitializeComponent();
                string sql = @"select * from Medicine_Info";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                this.dgvMedicineInfo.DataSource = ds.Tables[0];
                this.Da = new DataAccess();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select * from Medicine_Info where Medicine_name like'" + this.txtSearch.Text + "%'";
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvMedicineInfo.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc.Message);
            }
        }
    }
}
