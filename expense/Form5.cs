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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Server=AMEER-PC;Database=expense1;Integrated Security=true");
        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'expenseDataSet.exp' table. You can move, or remove it, as needed.
                SqlDataAdapter da = new SqlDataAdapter("select * from exp", cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp", cn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string a = comboBox1.SelectedItem.ToString();
                string c = comboBox2.SelectedItem.ToString();
                string b;

                if (a.Equals("january"))
                {
                    b = "01%" + c + "";
                    SqlDataAdapter da = new SqlDataAdapter("select * from exp where date like '" + b + "'", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp where date like '" + b + "'", cn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                    textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                    textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                    textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                }
                else if (a.Equals("february"))
                {
                    b = "02%" + c + "";
                    SqlDataAdapter da = new SqlDataAdapter("select * from exp where date like '" + b + "'", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp where date like '" + b + "'", cn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                    textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                    textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                    textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                }
                else if (a.Equals("march"))
                {
                    b = "03%" + c + "";
                    SqlDataAdapter da = new SqlDataAdapter("select * from exp where date like '" + b + "'", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp where date like '" + b + "'", cn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                    textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                    textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                    textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                }
                else if (a.Equals("april"))
                {
                    b = "04%" + c + "";
                    SqlDataAdapter da = new SqlDataAdapter("select * from exp where date like '" + b + "'", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp where date like '" + b + "'", cn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                    textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                    textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                    textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                }
                else if (a.Equals("may"))
                {
                    b = "05%" + c + "";
                    SqlDataAdapter da = new SqlDataAdapter("select * from exp where date like '" + b + "'", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp where date like '" + b + "'", cn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                    textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                    textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                    textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                }
                else if (a.Equals("june"))
                {
                    b = "06%" + c + "";
                    SqlDataAdapter da = new SqlDataAdapter("select * from exp where date like '" + b + "'", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp where date like '" + b + "'", cn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                    textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                    textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                    textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                }
                else if (a.Equals("july"))
                {
                    b = "07%" + c + "";
                    SqlDataAdapter da = new SqlDataAdapter("select * from exp where date like '" + b + "'", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp where date like '" + b + "'", cn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                    textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                    textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                    textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                }
                else  if (a.Equals("august"))
                {
                    b = "08%" + c + "";
                    SqlDataAdapter da = new SqlDataAdapter("select * from exp where date like '" + b + "'", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp where date like '" + b + "'", cn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                    textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                    textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                    textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                }
                else if (a.Equals("september"))
                {
                    b = "09%" + c + "";
                    SqlDataAdapter da = new SqlDataAdapter("select * from exp where date like '" + b + "'", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp where date like '" + b + "'", cn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                    textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                    textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                    textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                }
                else if (a.Equals("october"))
                {
                    b = "10%" + c + "";
                    SqlDataAdapter da = new SqlDataAdapter("select * from exp where date like '" + b + "'", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp where date like '" + b + "'", cn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                    textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                    textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                    textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                }
                else if (a.Equals("november"))
                {
                    b = "11%" + c + "";
                    SqlDataAdapter da = new SqlDataAdapter("select * from exp where date like '" + b + "'", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp where date like '" + b + "'", cn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                    textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                    textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                    textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                }
                else if (a.Equals("december"))
                {
                    b = "12%" + c + "";
                    SqlDataAdapter da = new SqlDataAdapter("select * from exp where date like '" + b + "'", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    SqlDataAdapter da1 = new SqlDataAdapter("select sum(transport),sum(food),sum(recharge),sum(rent),sum(others),sum(totalexpense),sum(deposit) from exp where date like '" + b + "'", cn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    textBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                    textBox2.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

                    textBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    textBox4.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

                    textBox5.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    textBox7.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();

                    textBox6.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();

                }
                else
                {
                    MessageBox.Show("Select month and year");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
