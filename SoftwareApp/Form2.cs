using Microsoft.VisualBasic;
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

                string Insert = "INSERT INTO User VALUES " + "(@id, @name, @email, @pass, @rule)";
                SqlCommand command = new SqlCommand(Insert, conn);

                command.Parameters.AddWithValue("@id", textBox4.Text);
                command.Parameters.AddWithValue("@name", textBox2.Text);
                command.Parameters.AddWithValue("@email", textBox1.Text);
                command.Parameters.AddWithValue("@pass", textBox3.Text);
                command.Parameters.AddWithValue("@type", radioButton1.Checked ? "Admin" : 0);
                command.Parameters.AddWithValue("@type", radioButton2.Checked ? "Organizer" : 0);
                command.Parameters.AddWithValue("@type", radioButton3.Checked ? "Customer" : 0);


                command.ExecuteNonQuery();

                MessageBox.Show("You've Registered your Account Successfully\n Go and LOGIN NOW!");

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
