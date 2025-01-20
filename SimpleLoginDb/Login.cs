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
using System.Xml.Linq;

namespace SimpleLoginDb
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtPass.Text))
                {
                    MessageBox.Show("Please fill User Id and Password to continue");
                    return;
                }

                string sql = "select * from UserRole where Id = '" + this.txtUserId.Text + "' and Password = '" + this.txtPass.Text + "';";
                SqlConnection sqlcon = new SqlConnection(@"Data Source=KHALED-0195;Initial Catalog=master;Integrated Security=True;Encrypt=False;");
                sqlcon.Open();
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);

            //var id = ds.Tables[0].Rows[0][0].ToString();

            if (ds.Tables[0].Rows.Count == 1)
            {
                this.Hide();
                MessageBox.Show("Valid User");

                    if (ds.Tables[0].Rows[0][1].ToString().Equals("admin"))

                        new Admin().Show();

                    else if (ds.Tables[0].Rows[0][1].ToString().Equals("member"))

                        new Member().Show();
                }
            else
            {
                MessageBox.Show("Invalid User");
            }

            sqlcon.Close();
        }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured" + exc.Message);
                }


    //bool notFound = true;
    //int index = 0;
    //while (index < ds.Tables[0].Rows.Count)
    //{
    //    if (this.txtUserId.Text == ds.Tables[0].Rows[index][0].ToString() && this.txtPass.Text == ds.Tables[0].Rows[index][2].ToString())
    //    {
    //    if (ds.Tables[0].Rows[index][1].ToString().Equals("admin"))
    //        new Admin(ds.Tables[0].Rows[index][0].ToString(), this).Show();
    //    else if (ds.Tables[0].Rows[index][1].ToString().Equals("member"))
    //        new Member(ds.Tables[0].Rows[index][0].ToString(), this).Show();
    //    notFound = false;
    //        MessageBox.Show("Valid User");


    //    break;
    //    }
    //    //else
    //    //{
    //    //    MessageBox.Show("Invalid User");
    //    //}
    //    index++;
    //}
    //if (notFound)
    //    MessageBox.Show("Invalid User");




}
    }
}
