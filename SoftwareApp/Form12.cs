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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
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
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string? eventName = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";
            string connString = "Server= localhost; Database= EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string sqlQuerySelect =
                "SELECT SPONSOR.ID , SPONSOR.NAME , SPONSOR.DESCRIPTION " +
                "FROM SPONSOR " +
                "INNER JOIN EVENT ON SPONSOR.EVENTID = EVENT.ID " +
                "WHERE EVENT.NAME = @eventName;";
                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                command.Parameters.AddWithValue("@eventName", eventName);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
