using FontAwesome.Sharp;
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
    public partial class PgInvoices : UserControl
    {
        private DataAccess Da { get; set; }

        public SignIn F2
        {

            get; set;
        }
        public PgInvoices()
        {
            InitializeComponent();
            try
            {
                
                string sql = @"Select * from medicine_info";
                SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-1O6EH635;Initial Catalog=PharmacyStoreManagement;Integrated Security=True");
                sqlcon.Open();
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sqladp = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sqladp.Fill(ds);
                this.dgvMedicineList.AutoGenerateColumns = false;
                this.dgvMedicineList.DataSource = ds.Tables[0];
                this.Da = new DataAccess();
                this.AutoIdGenerate();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc.Message);
            }
            

        }
     
        private int currentRowNumber = 1;

       

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = @"Select * from medicine_info Where Medicine_name like '" + this.txtSearch.Text + "%' ";
            // DataAccess da = new DataAccess();
            // DataSet ds = da.ExecuteQuery(sql);
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-1O6EH635;Initial Catalog=PharmacyStoreManagement;Integrated Security=True");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sqladp = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sqladp.Fill(ds);
            this.dgvMedicineList.DataSource = ds.Tables[0];
        }
        private void AutoIdGenerate()
        {
            var sql = "select Order_Id from dbo.TNS_Sales  order by Order_Id desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
          //  string[] s = oldId.Split('-');
            int temp = Convert.ToInt32(oldId);
            int newId = ++temp;
            this.txtOrderId.Text = Convert.ToString(newId);
        }
        protected void add()
        {
            try
            {
                foreach (DataGridViewRow row in dgvBill.Rows)
            {
                // Create a new SqlCommand object to execute the INSERT statement
                using (SqlCommand cmd = new SqlCommand())
                {
                    // Set the SqlCommand object's properties
                    string connectionString = @"Data Source=LAPTOP-1O6EH635;Initial Catalog=PharmacyStoreManagement;Integrated Security=True";
                    cmd.Connection = new SqlConnection(connectionString);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"INSERT INTO dbo.TNS_Sales VALUES ('"+ this.txtOrderId.Text + "',@MedicineName,@Date, @Quantity,@TotalPrice)";

                    // Add the parameter values to the SqlCommand object
                    cmd.Parameters.AddWithValue("@MedicineName", row.Cells["Medicine_Name"].Value);
                    cmd.Parameters.AddWithValue("@Quantity", row.Cells["Sales_Quantity"].Value);
                    cmd.Parameters.AddWithValue("@TotalPrice", row.Cells["Total_Price"].Value);
                    cmd.Parameters.AddWithValue("@Date", row.Cells["Date"].Value);

                    // Open the database connection and execute the INSERT statement
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
            }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc.Message);
            }

        }
        private void Refresh()
        {
            try
            {
                string sql = @"select * from Medicine_Info;";
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvBill.AutoGenerateColumns = (false);
                this.dgvMedicineList.DataSource = ds.Tables[0];
                this.dgvBill.ClearSelection();
                this.txtQuantity.Clear();
                this.txtOrderId.Clear();                   
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc.Message);
            }
        }
        private void UpdateQuantity(DataGridView availableDataGridView, TextBox salesTextBox, string connectionString)
        {
            try
            {

                int salesQty = Convert.ToInt32(salesTextBox.Text);
                // Loop through each row in the sales DataGridView control
                foreach (DataGridViewRow row in availableDataGridView.Rows)
                {
                    // Get the current available quantity and sales quantity values
                    int availableQty = Convert.ToInt32(row.Cells["Quantity"].Value);


                    // Calculate the new available quantity
                    int newQty = availableQty - salesQty;

                    // Update the database record with the new available quantity
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        // Set the SqlCommand object's properties
                        cmd.Connection = new SqlConnection(connectionString);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE [dbo].[Medicine_Info] SET [Quantity] = @newQty WHERE Medicine_Name = '@name'";

                        // Add the parameter values to the SqlCommand object
                        cmd.Parameters.AddWithValue("@newQty", newQty);
                        cmd.Parameters.AddWithValue("@name", row.Cells["IName"].Value);

                        // Open the database connection and execute the UPDATE statement
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }

                    // Update the available DataGridView control with the new available quantity
                    row.Cells["Quantity"].Value = newQty;
                }
                salesTextBox.Text = "0";
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc.Message);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string billString = "Bill Details\n";
            billString += "-------------------------\n";
            billString += "Order Id: " + txtOrderId.Text + "\n";
            billString += "-------------------------\n";


            // Loop through the rows in the second datagridview and add them to the string
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                billString += row.Cells[0].Value.ToString() + "\t";
                billString += row.Cells[1].Value.ToString() + "\t";
                billString += row.Cells[2].Value.ToString() + "\t";
                billString += row.Cells[3].Value.ToString() + "\t";
                billString += row.Cells[4].Value.ToString() + "\t\n";
                //billString += row.Cells[5].Value.ToString() + "\n";
            }

            // Add the total bill to the string
            billString += "\t\t-------------------------\n";
            billString += "\t\tTotal Bill: " + lblTotalBill.Text + "\n";

            // Add the payment amount and date/time to the string
            billString += "-------------------------\n";
            billString += "Payment Amount: " + txtPaymentMethod.Text + "\n";
            billString += "Date/Time: " + DateTime.Now.ToString() + "\n";

            // Display the bill string in a message box
            MessageBox.Show(billString, "Print Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refresh();
            AutoIdGenerate();

            //UpdateQuantity(dgvMedicineList, txtQuantity, connectionString);



            //UpdateQuantity(dgvMedicineList,txtQuantity,connectionString);
        }

        private void gunaBtnAddToBill_Click_1(object sender, EventArgs e)
        {
            try
            {

                DataGridViewRow selectedRow = dgvMedicineList.SelectedRows[0];
            int quantity = int.Parse(txtQuantity.Text);
            decimal price = decimal.Parse(selectedRow.Cells[2].Value.ToString());
            decimal totalPrice = (price * quantity);
            string Date = (dateTimePicker1.Text);
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = currentRowNumber++ });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = Date });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = selectedRow.Cells[0].Value });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = selectedRow.Cells[2].Value });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = quantity });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = totalPrice });

            dgvBill.Rows.Add(newRow);

            decimal totalBill = 0;
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                decimal rowTotalPrice = decimal.Parse(row.Cells[5].Value.ToString());
                totalBill += rowTotalPrice;
            }
            lblTotalBill.Text = totalBill.ToString();
            add();
            Refresh();
            AutoIdGenerate();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Please Select a Medicine");
            }
        }

       
    }
}
