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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Server=AMEER-PC;Database=expense1;Integrated Security=true");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from exp where date='" + dateTimePicker1.Value.ToShortDateString() + "'", cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                textBox1.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                textBox2.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                textBox3.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
                textBox4.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
                textBox5.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                textBox6.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                textBox7.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
                textBox8.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(9).ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string trp = textBox1.Text;
                int trp1 = int.Parse(trp);
                int fd = int.Parse(textBox2.Text);
                int rc = int.Parse(textBox3.Text);
                int rt = int.Parse(textBox4.Text);
                int ot = int.Parse(textBox5.Text);
                int dp = int.Parse(textBox7.Text);
                int bl = int.Parse(textBox8.Text);
                int te = trp1 + fd + rc + rt + ot;
                SqlCommand cmd = new SqlCommand("update exp set transport='" + trp1 + "',food='" + fd + "',recharge='" + rc + "',rent='" + rt + "',others='" + ot + "',description='" + textBox6.Text + "',totalexpense='"+te+"',deposit='" + dp + "',balance='" + bl + "' where date='" + dateTimePicker1.Value.ToShortDateString() + "'",cn);
                cn.Open();
                int kn = cmd.ExecuteNonQuery();
                cn.Close();
                if (kn > 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
