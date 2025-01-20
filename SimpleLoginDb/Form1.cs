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

namespace SimpleLoginDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //Data Source=KHALED-0195;Initial Catalog=master;Integrated Security=True;Encrypt=False;Trust Server Certificate=True



            SqlConnection sqlcon = new SqlConnection(@"Data Source=KHALED-0195;Initial Catalog=master;Integrated Security=True;Encrypt=False;");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand("Select * from SampleStudentInfo;", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            this.label1.Text = ds.Tables[0].Rows[0][0].ToString();
            this.label2.Text = ds.Tables[0].Rows[0][1].ToString();
            this.label3.Text = ds.Tables[0].Rows[0][3].ToString();
            this.label4.Text = ds.Tables[0].Rows[1][0].ToString();

            //this.label2.Text = ds.Tables[0].Rows[0][1].ToString();

            //this.label3.Text = ds.Tables[0].Rows[2][2].ToString();
            //this.label4.Text = ds.Tables[0].Rows[0][3].ToString();

            sqlcon.Close();

        }
    }
}
