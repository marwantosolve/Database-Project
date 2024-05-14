﻿using Microsoft.VisualBasic;
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
                string insert = "INSERT INTO [USER] VALUES (@id, @name, @email, @pass, @role);";
                using (SqlCommand command = new SqlCommand(insert, conn))
                {
                    command.Parameters.AddWithValue("@id", textBox4.Text);
                    command.Parameters.AddWithValue("@name", textBox2.Text);
                    command.Parameters.AddWithValue("@email", textBox1.Text);
                    command.Parameters.AddWithValue("@pass", textBox3.Text);
                    String role = "";
                    if (radioButton1.Checked)
                    {
                        role = "Admin";
                    }
                    else if (radioButton2.Checked)
                    {
                        role = "Organizer";
                    }
                    else if (radioButton3.Checked)
                    {
                        role = "Customer";
                    }
                    else
                    {
                        MessageBox.Show("You have to select a role !");
                    }
                    command.Parameters.AddWithValue("@role", role);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("You've Registered your Account Successfully ✓\nGo LOGIN NOW !");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
