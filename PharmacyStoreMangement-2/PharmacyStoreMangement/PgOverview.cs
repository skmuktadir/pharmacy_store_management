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
    public partial class PgOverview : UserControl
    {
        private DataAccess Da { get; set; }
        public PgOverview()
        {
            //this.lblUserName.Text = Global.userName;
            InitializeComponent();
        }
        private void fillChart()
        {
            string selectedItem = cmbYear.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-1O6EH635;Initial Catalog=PharmacyStoreManagement;Integrated Security=True");
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(@"select Datename(MONTH,[Date]) as month, sum([Total_Price]) as TotalPrice from [dbo].[TNS_Sales] where Year(date)= "+selectedItem+" group by  Datename(MONTH,[Date]),month([Date])", conn);
            da.Fill(dt);
            chart1.DataSource = dt;
            conn.Close();
            chart1.Series["Sales"].Points.Clear();
            chart1.Series["Sales"].XValueMember = "MONTH";
            chart1.Series["Sales"].YValueMembers = "TotalPrice";
        }
        private void fillChart2()
        {
           // this.label7.Text = cmbYear.SelectedItem.ToString();
            string selectedItem = cmbYear.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-1O6EH635;Initial Catalog=PharmacyStoreManagement;Integrated Security=True");
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT top 5 [Medicine_name],[Total_Price] from [dbo].[TNS_Sales] where Year(date)= "+selectedItem+" order by [Total_Price] desc;", conn);
            da.Fill(dt);
            chart2.DataSource = dt;
            conn.Close();
            chart2.Series[0].Points.Clear();
            chart2.Series[0].XValueMember = "Medicine_name";
            chart2.Series[0].YValueMembers = "Total_Price";
        }

        private void PgOverview_Load(object sender, EventArgs e)
        {
            cmbYear.SelectedIndex = 0;
            FillLabel2();

            RecentTransaction();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillChart();
            fillChart2();
            FillLabel();
           


        }
        private void RecentTransaction()
        {
            try
            {
               
                string sql = @"SELECT top 5 dbo.TNS_Sales.Order_Id, dbo.TNS_Sales.Medicine_name, dbo.TNS_Sales.Date, dbo.TNS_Sales.Sales_Quantity, dbo.Medicine_Info.Unit_Price,dbo.TNS_Sales.Total_price FROM     dbo.Medicine_Info INNER JOIN dbo.TNS_Sales ON dbo.Medicine_Info.Medicine_name = dbo.TNS_Sales.Medicine_name Order by Order_Id Desc";
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

        private void FillLabel()
        {

            string selectedItem = cmbYear.SelectedItem.ToString();
            string sql = @"select sum([Total_Price]) from [dbo].[TNS_Sales] where Year(Date) =" + selectedItem + ";";

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-1O6EH635;Initial Catalog=PharmacyStoreManagement;Integrated Security=True");

            conn.Open();
            SqlCommand da = new SqlCommand(sql, conn);


            SqlDataReader dr = da.ExecuteReader();
            while (dr.Read()) { this.label3.Text = dr.GetValue(0).ToString(); }
            conn.Close();
        }
        private void FillLabel2()
        {

           // string selectedItem = cmbYear.SelectedItem.ToString();
            string sql = @"select Count([Medicine_name]) from [dbo].[Medicine_Info];";

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-1O6EH635;Initial Catalog=PharmacyStoreManagement;Integrated Security=True");

            conn.Open();
            SqlCommand da = new SqlCommand(sql, conn);


            SqlDataReader dr = da.ExecuteReader();
            while (dr.Read()) { this.label4.Text = dr.GetValue(0).ToString(); }
            conn.Close();
        }

    }
}
