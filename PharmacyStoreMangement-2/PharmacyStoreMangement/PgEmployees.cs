using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PharmacyStoreMangement
{
    public partial class PgEmployees : UserControl
    {
        private DataAccess Da { get; set; }
        private void PopularGridView(string sql= "select * from Login_Table;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvSalespersons.AutoGenerateColumns = false;
            this.dgvSalespersons.DataSource = ds;
        }
     public PgEmployees()
        {
            try
            {
                InitializeComponent();
                string sql = @"select * from Login_Table;";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                this.dgvSalespersons.DataSource = ds.Tables[0];
                this.Da = new DataAccess();
                this.AutoIdGenerate();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc.Message);
            }
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtUserName.Text) || string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtRole.Text))
                {
                    MessageBox.Show("Please fill all the data");
                    return;
                }

                var query = @"select * from Login_Table where User_Id='" + this.txtUserId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update Login_Table 
                                set User_Id='" + this.txtUserId.Text + @"',
                                User_Name='" + this.txtUserName.Text + @"',
                                User_Password=" + this.txtPassword.Text + @",
                                User_Role='" + this.txtRole.Text + @"'
                                where User_Id='" + this.txtUserId.Text + @"';";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated Properly");
                    else
                        MessageBox.Show("Data upgradation Failed");
                }
                else
                {
                    //insert
                    string sql = @"insert into Login_Table values('" + this.txtUserId.Text + "','" + this.txtUserName.Text + "'," + this.txtPassword.Text + ",'" + this.txtRole.Text + "');";
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
                string sql = @"select * from Login_Table;";
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvSalespersons.AutoGenerateColumns = (false);
                this.dgvSalespersons.DataSource = ds.Tables[0];
                this.txtUserId.Clear();
                this.txtUserName.Clear();
                this.txtPassword.Clear();
                this.txtRole.Clear();
                this.AutoIdGenerate();
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
                string sql = @"select * from Login_Table where User_Name like'" + this.txtSearch.Text + "%'";
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvSalespersons.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //int rowIndex = dgvSalespersons.CurrentCell.RowIndex;
                //Console.WriteLine(rowIndex);
               // var id = this.dgvSalespersons.Rows[rowIndex].Cells["User_Id"].Value;
                var id = this.dgvSalespersons.CurrentRow.Cells["User_Id"].Value;
                var name= this.dgvSalespersons.CurrentRow.Cells["User_Name"].Value;
                string sql = @"delete from Login_Table where User_Id='"+id+"';";
                int count =this.Da.ExecuteDMLQuery(sql);
                if(count > 0) 
                {
                    MessageBox.Show(name+" Delete Successfully"); 
                
                }
                else 
                {
                    MessageBox.Show(" Delete not Successfully");
                }
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvSalespersons.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                //MessageBox.Show();
            }
        }

        private void dgvSalespersons_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserId.Text = this.dgvSalespersons.CurrentRow.Cells["User_Id"].Value.ToString();
            this.txtUserName.Text = this.dgvSalespersons.CurrentRow.Cells["User_Name"].Value.ToString();
            this.txtPassword.Text = this.dgvSalespersons.CurrentRow.Cells["Password"].Value.ToString();
            this.txtRole.Text = this.dgvSalespersons.CurrentRow.Cells["Role"].Value.ToString();
        }
        private void AutoIdGenerate()
        {
            var sql = "select User_Id from Login_Table order by User_Id desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] s = oldId.Split('-');
            int temp = Convert.ToInt32(s[1]);
            string newId = "member-" + (++temp).ToString("d3");
            this.txtUserId.Text = newId;
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

