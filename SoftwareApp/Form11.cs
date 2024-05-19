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

namespace SoftwareApp
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox1.Enabled = checkBox3.Checked;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date = textBox4.Text;
            string loc = textBox1.Text;
            comboBox1.SelectedItem = "";
            string? type = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";
            string connString = "Server= localhost; Database= EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    string sqlQuerySelect = "SELECT [ID], [NAME] FROM EVENT WHERE LOCATION = @loc AND DATE = @date AND TYPE = @type;";
                    SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                    command.Parameters.AddWithValue("@loc", loc);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@type", type);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No matching records found.");
                            dataGridView1.DataSource = "";
                        }
                    }
                }
                else if (checkBox1.Checked && checkBox2.Checked)
                {
                    string sqlQuerySelect = "SELECT [ID], [NAME] FROM EVENT WHERE LOCATION = @loc AND DATE = @date;";
                    SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                    command.Parameters.AddWithValue("@loc", loc);
                    command.Parameters.AddWithValue("@date", date);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No matching records found.");
                            dataGridView1.DataSource = "";
                        }
                    }
                }
                else if (checkBox2.Checked && checkBox3.Checked)
                {
                    string sqlQuerySelect = "SELECT [ID], [NAME] FROM EVENT WHERE LOCATION = @loc AND TYPE = @type;";
                    SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                    command.Parameters.AddWithValue("@loc", loc);
                    command.Parameters.AddWithValue("@type", type);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No matching records found.");
                            dataGridView1.DataSource = "";
                        }
                    }
                }
                else if (checkBox1.Checked && checkBox3.Checked)
                {
                    string sqlQuerySelect = "SELECT [ID], [NAME] FROM EVENT WHERE DATE = @date AND TYPE = @type;";
                    SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@type", type);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No matching records found.");
                            dataGridView1.DataSource = "";
                        }
                    }
                }
                else if (checkBox1.Checked)
                {
                    string sqlQuerySelect = "SELECT [ID], [NAME] FROM EVENT WHERE DATE = @date;";
                    SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                    command.Parameters.AddWithValue("@date", date);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No matching records found.");
                            dataGridView1.DataSource = "";
                        }
                    }
                }
                else if (checkBox2.Checked)
                {
                    string sqlQuerySelect = "SELECT [ID], [NAME] FROM EVENT WHERE LOCATION = @loc;";
                    SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                    command.Parameters.AddWithValue("@loc", loc);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No matching records found.");
                            dataGridView1.DataSource = "";
                        }
                    }
                }
                else if (checkBox3.Checked)
                {
                    string sqlQuerySelect = "SELECT [ID], [NAME] FROM EVENT WHERE TYPE = @type;";
                    SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                    command.Parameters.AddWithValue("@type", type);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No matching records found.");
                            dataGridView1.DataSource = "";
                        }
                    }
                }
                else
                {
                    dataGridView1.DataSource = "";
                    return;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                dataGridView1.DataSource = "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}     
