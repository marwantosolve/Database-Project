using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SoftwareApp
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string? eventName = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";
            int custID = SharedData.custID;
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
            string connString = "Server= localhost; Database= EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                string sqlQuerySelect =
                "SELECT TICKET.ID, TICKET.PRICE, TICKET.DATE " +
                "FROM [TICKET] " +
                "INNER JOIN [EVENT] ON TICKET.EVENTID = EVENT.ID " +
                "WHERE EVENT.NAME = @eventName " +
                "AND TICKET.ISAVALIABLE = 1 " +
                "AND TICKET.TYPE = @type;";
                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                command.Parameters.AddWithValue("@eventName", eventName);
                command.Parameters.AddWithValue("@type", type);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int custID = SharedData.custID;
            var selectedRow = dataGridView1.SelectedRows[0];
            int ticketID = Convert.ToInt32(selectedRow.Cells["id"].Value);
            string connString = "Server= localhost; Database= EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string updateQuery = "UPDATE [TICKET] SET ISAVALIABLE = 0, CUSTID = @custID WHERE ID = @ticketID";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@ticketID", ticketID);
                cmd.Parameters.AddWithValue("@custID", custID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You've Purchased the Ticket Successfully !", "Purchased Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
