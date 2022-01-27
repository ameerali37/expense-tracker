using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace expense
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Server=AMEER-PC;Database=expense1;Integrated Security=true");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Enter Current Password, New Password and Verify New Password");
                }
                else
                {
                    string cpswd = textBox1.Text;
                    SqlDataAdapter da2 = new SqlDataAdapter("select * from login where pwd='" + cpswd + "'", cn);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);
                    if (ds2.Tables[0].Rows.Count > 0)
                    {
                        string a1 = textBox2.Text;
                        string a2 = textBox3.Text;
                        if(a1.Equals(a2))
                        {
                        SqlCommand cmp = new SqlCommand("update login set pwd='" + a2 + "'", cn);

                        cn.Open();
                        int status1 = cmp.ExecuteNonQuery();
                        cn.Close();

                        if (status1 > 0)
                        {
                            MessageBox.Show("Password Changed");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                        }
                        else
                        {
                            MessageBox.Show("Password does not match");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Current Password Entered is Wrong");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
