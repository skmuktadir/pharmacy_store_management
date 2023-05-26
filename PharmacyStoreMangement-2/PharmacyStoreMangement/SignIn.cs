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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-1O6EH635;Initial Catalog=UserDB;Integrated Security=True");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand("select * from Login_Table ;", sqlcon);
            SqlDataAdapter sqladp = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sqladp.Fill(ds);
            int count = 0;
            int flag = 0;
            while (count < ds.Tables[0].Rows.Count)
            {
                if (this.textUserId.Text.ToLower() == ds.Tables[0].Rows[count][0].ToString() && this.textPassword.Text == ds.Tables[0].Rows[count][2].ToString())
                {
                    MessageBox.Show("Login Valid");
                    flag = 1;
                    if (ds.Tables[0].Rows[count][3].ToString() == "admin")
                    {
                        this.Hide();
                        FormAdmin admin = new FormAdmin(this);
                        admin.Show();
                    }
                    else
                    {
                        this.Hide();
                        Member member = new Member(this);
                        member.Show();

                    }
                    break;
                }
                count++;
            }
            if (flag == 0)
                MessageBox.Show("Login InValid");


        }

    }
    }

