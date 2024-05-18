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
    public partial class Form13 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RIMAZ\MSSQLSERVER2; Database=Event; Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        SqlCommand cmd;
        public Form13()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                int ticketid = Convert.ToInt32(txt_ticketid.Text);
                int custid = Convert.ToInt32(txt_custid.Text);

                conn.Open();

                string updateQuery = "UPDATE ticket SET ISAVALIABLE = 1, CUSTID = 'NULL' WHERE CUSTID = @custid AND ID = @ticketid ";

                SqlCommand cmd = new SqlCommand(updateQuery, conn);

                cmd.Parameters.AddWithValue("@ticketid", ticketid);
                cmd.Parameters.AddWithValue("@custid", custid);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Ticket has been returned successfully.");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while returning the ticket: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txt_ticketid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
