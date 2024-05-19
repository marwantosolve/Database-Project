using Microsoft.VisualBasic.Logging;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SoftwareApp
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox6.Text;
            string desc = textBox1.Text;
            string? eventName = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";
            string connString = "Server= localhost; Database= EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string insert = " INSERT INTO SPONSOR (EVENTID, NAME, DESCRIPTION)" +
                    "VALUES ((SELECT EVENT.ID FROM EVENT WHERE EVENT.NAME = @eventName), @name, @desc);";
                using (SqlCommand command = new SqlCommand(insert, conn))
                {
                    command.Parameters.AddWithValue("@eventName", eventName);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@desc", desc);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Sponsor Added Successfully !", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form8_Load(object sender, EventArgs e)
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
    }
}
