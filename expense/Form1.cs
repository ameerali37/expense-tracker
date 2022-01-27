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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Server=AMEER-PC;Database=expense1;Integrated Security=true");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from login", cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string a = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                string b = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                string c = textBox1.Text;
                string d = textBox2.Text;
                if (a.Equals(c) && b.Equals(d))
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
