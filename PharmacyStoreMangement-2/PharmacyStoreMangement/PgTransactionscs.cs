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
    public partial class PgTransactionscs : UserControl
    {
        private DataAccess Da { get; set; }

        public PgTransactionscs()
        {
              
                try
                {
                    InitializeComponent();
                    string sql = @"SELECT dbo.TNS_Sales.Order_Id, dbo.TNS_Sales.Medicine_name, dbo.TNS_Sales.Date, dbo.TNS_Sales.Sales_Quantity, dbo.Medicine_Info.Unit_Price,dbo.TNS_Sales.Total_price FROM     dbo.Medicine_Info INNER JOIN dbo.TNS_Sales ON dbo.Medicine_Info.Medicine_name = dbo.TNS_Sales.Medicine_name Order by Order_Id Desc";
                    DataAccess da = new DataAccess();
                    DataSet ds = da.ExecuteQuery(sql);
                    this.dgvTransactions.DataSource = ds.Tables[0];
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
                string sql = @"SELECT dbo.TNS_Sales.Order_Id, dbo.TNS_Sales.Medicine_name, dbo.TNS_Sales.Date, dbo.TNS_Sales.Sales_Quantity, dbo.Medicine_Info.Unit_Price,dbo.TNS_Sales.Total_price FROM     dbo.Medicine_Info INNER JOIN dbo.TNS_Sales ON dbo.Medicine_Info.Medicine_name = dbo.TNS_Sales.Medicine_name where Order_id like '" + this.txtSearch.Text + "%'";
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvTransactions.AutoGenerateColumns = false;
                this.dgvTransactions.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc.Message);
            }
        }

      
    }
}
