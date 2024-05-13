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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Server= localhost; Database= EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                string Insert = "INSERT INTO User VALUES " + "(@id, @name, @email, @pass, @type)";
                SqlCommand command = new SqlCommand(Insert, conn);

                //command.Parameters.AddWithValue("@id", .Text);
                //command.Parameters.AddWithValue("@name", .Text); //YYYY-MM-DD
                //command.Parameters.AddWithValue("@email", .Text);
                //command.Parameters.AddWithValue("@pass", .Text);
                //command.Parameters.AddWithValue("@type", .Checked ? "Admin");
                //command.Parameters.AddWithValue("@type", .Checked ? "Organizer");
                //command.Parameters.AddWithValue("@type", .Checked ? "Customer");


                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
