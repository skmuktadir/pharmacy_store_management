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
    public partial class PgMedicine : UserControl
    {
        private DataAccess Da { get; set; }
        private void PopularGridView(string sql = @"select * from Medicine_Info")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvMedicineInfo.AutoGenerateColumns = false;
            this.dgvMedicineInfo.DataSource = ds;
        }
        public PgMedicine()
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

        private void btnMedicineAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(this.txtMedicine.Text) || string.IsNullOrEmpty(this.textUprice.Text) || string.IsNullOrEmpty(this.textType.Text) )
            {
                MessageBox.Show("Please fill all the data");
                return;
            }

            var query = @"select * from Medicine_Info where Medicine_name='" + this.txtMedicine.Text + "';";

            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                //update
                var sql = @"update Medicine_Info 
                                set Medicine_name='" + this.txtMedicine.Text + @"',
                                
                                Unit_Price=" + this.textUprice.Text + @",
                                Type='" + this.textType.Text + @"'
                                where Medicine_name='" + this.txtMedicine.Text + @"';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data updated Properly");
                else
                    MessageBox.Show("Data upgradation Failed");
            }
            else
            {
                //insert
                string sql = @"insert into Medicine_Info values('" + this.txtMedicine.Text + "','" + this.textType.Text + "','" + this.textUprice.Text + "');";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data Added Properly");
                else
                    MessageBox.Show("Data Insertion Failed");
            }

            this.PopularGridView();

        }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select * from Medicine_Info;";
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvMedicineInfo.AutoGenerateColumns = (false);
                this.dgvMedicineInfo.DataSource = ds.Tables[0];
                this.txtMedicine.Clear();
                this.textUprice.Clear();
                this.textType.Clear();
               
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc.Message);
            }
        }

        private void btnMedicineDlt_Click(object sender, EventArgs e)
        {
            try
            {
                //int rowIndex = dgvSalespersons.CurrentCell.RowIndex;
                //Console.WriteLine(rowIndex);
                // var id = this.dgvSalespersons.Rows[rowIndex].Cells["User_Id"].Value;
                var id = this.dgvMedicineInfo.CurrentRow.Cells["User_Id"].Value;
                var name = this.dgvMedicineInfo.CurrentRow.Cells["User_Name"].Value;
                string sql = @"delete from Medicine_Info where Medicine_name='" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count > 0)
                {
                    MessageBox.Show(name + " Delete Successfully");

                }
                else
                {
                    MessageBox.Show(" Delete not Successfully");
                }
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvMedicineInfo.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                //MessageBox.Show();
            }
        }

        private void dgvMedicineInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtMedicine.Text = this.dgvMedicineInfo.CurrentRow.Cells["Medicine_Name"].Value.ToString();
            this.textType.Text = this.dgvMedicineInfo.CurrentRow.Cells["type"].Value.ToString();
           // this.textQuantity.Text = this.dgvMedicineInfo.CurrentRow.Cells["Quantity"].Value.ToString();
            this.textUprice.Text = this.dgvMedicineInfo.CurrentRow.Cells["Unit_Price"].Value.ToString();
        }
    }
    }

