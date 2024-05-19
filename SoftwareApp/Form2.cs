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

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked))
                {
                    MessageBox.Show("You must complete your information first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (radioButton1.Checked)
                {
                    // Admin
                    conn.Open();
                    string insert = "INSERT INTO [ADMIN] VALUES (@id, @name, @email, @pass);";
                    using (SqlCommand command = new SqlCommand(insert, conn))
                    {
                        command.Parameters.AddWithValue("@id", textBox4.Text);
                        command.Parameters.AddWithValue("@name", textBox2.Text);
                        command.Parameters.AddWithValue("@email", textBox1.Text);
                        command.Parameters.AddWithValue("@pass", textBox3.Text);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("You've Registered your Account Successfully ✓\nGo LOGIN NOW !", "Registered Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                else if (radioButton2.Checked)
                {
                    // Organizer
                    conn.Open();
                    string insert = "INSERT INTO [ORGANIZER] VALUES (@id, @name, @email, @pass);";
                    using (SqlCommand command = new SqlCommand(insert, conn))
                    {
                        command.Parameters.AddWithValue("@id", textBox4.Text);
                        command.Parameters.AddWithValue("@name", textBox2.Text);
                        command.Parameters.AddWithValue("@email", textBox1.Text);
                        command.Parameters.AddWithValue("@pass", textBox3.Text);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("You've Registered your Account Successfully ✓\nGo LOGIN NOW !", "Registered Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                else if (radioButton3.Checked)
                {
                    // Customer
                    conn.Open();
                    string insert = "INSERT INTO [CUSTOMER] VALUES (@id, @name, @email, @pass);";
                    using (SqlCommand command = new SqlCommand(insert, conn))
                    {
                        command.Parameters.AddWithValue("@id", textBox4.Text);
                        command.Parameters.AddWithValue("@name", textBox2.Text);
                        command.Parameters.AddWithValue("@email", textBox1.Text);
                        command.Parameters.AddWithValue("@pass", textBox3.Text);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("You've Registered your Account Successfully ✓\nGo LOGIN NOW !", "Registered Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
