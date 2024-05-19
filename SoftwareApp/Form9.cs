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

namespace SoftwareApp
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string connString = "Server= localhost; Database= EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string sqlQuerySelect = "SELECT [NAME] FROM EVENT;";
                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string eventName = reader.GetString("NAME");
                        comboBox1.Items.Add(eventName);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string? eventName = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";
            string type = "";
            if (radioButton1.Checked)
            {
                type = "Platinum";
            }
            else if (radioButton2.Checked)
            {
                type = "Gold";
            }
            else if (radioButton3.Checked)
            {
                type = "Silver";
            }
            string price = textBox1.Text;
            if (int.TryParse(price, out int custID))
            {
                SharedData.custID = custID;
            }
            string date = textBox2.Text;
            string connString = "Server= localhost; Database= EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string insert = " INSERT INTO TICKET (EVENTID, TYPE, PRICE, DATE)" +
                    "VALUES ((SELECT EVENT.ID FROM EVENT WHERE EVENT.NAME = @eventName), @type, @price, @date);";
                using (SqlCommand command = new SqlCommand(insert, conn))
                {
                    command.Parameters.AddWithValue("@eventName", eventName);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@date", date);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Ticket Added Successfully !", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
