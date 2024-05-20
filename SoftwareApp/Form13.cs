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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareApp
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Server= localhost; Database= EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            DialogResult result = MessageBox.Show("Are you sure you want to Return your Ticket?", "Confirm Return Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string sqlQueryInsert = "DELETE FROM [TICKET] WHERE ID = @id AND CUSTID = @cid ;";
                    SqlCommand command = new SqlCommand(sqlQueryInsert, conn);
                    command.Parameters.AddWithValue("@id", textBox3.Text);
                    command.Parameters.AddWithValue("@cid", textBox4.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("You've Returned your Ticket Successfully !", "Returned Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
