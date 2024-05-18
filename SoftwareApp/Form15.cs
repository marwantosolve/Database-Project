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

namespace SoftwareApp
{
    public partial class Form15 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RIMAZ\MSSQLSERVER2; Database=Event; Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        SqlCommand cmd;
        string type;
        public Form15()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_purchase_Click(object sender, EventArgs e)
        {
            if(radioButton_plat.Checked==true)
            {
                type = "Platinum";
            }
            else if(radioButton_gold.Checked==true)
            {
                type = "Gold";
            }
            else if(radioButton_silver.Checked==true)
            {
                type = "Silver";
            }

            if (radioButton_gold.Checked == true ^ radioButton_gold.Checked == true ^ radioButton_silver.Checked == true)
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO TICKET(type) VALUES (@type)";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@type", type);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket has been purchased successfully.");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred purchasing the ticket: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please choose one ticket.");
            }
            
        }
    }
}
