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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Server=AMEER-PC;Database=expense1;Integrated Security=true");
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand("Insert into exp values(@date,@transport,@food,@recharge,@rent,@others,@description,@totalexpense,@deposit,@balance)", cn);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@transport", trp1);
                cmd.Parameters.AddWithValue("@food", fd);
                cmd.Parameters.AddWithValue("@recharge", rc);
                cmd.Parameters.AddWithValue("@rent", rt);
                cmd.Parameters.AddWithValue("@others", ot);
                cmd.Parameters.AddWithValue("@description", textBox6.Text);
                cmd.Parameters.AddWithValue("@totalexpense", te);
                cmd.Parameters.AddWithValue("@deposit", dp);
                cmd.Parameters.AddWithValue("@balance", bl);

                cn.Open();
                int n = cmd.ExecuteNonQuery();
                cn.Close();
                if (n > 0)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
