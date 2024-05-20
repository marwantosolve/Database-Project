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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SoftwareApp
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text == "" || textBox2.Text == "" || textBox6.Text == "" || comboBox1.SelectedItem == "")
            {
                MessageBox.Show("You must complete Event information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string? type = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";
            string name = textBox6.Text;
            string loc = textBox1.Text;
            string date = textBox2.Text;
            string connString = "Server= localhost; Database= EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string insert = "INSERT INTO [EVENT] (NAME, TYPE, LOCATION, DATE) VALUES (@name, @type, @loc, @date);";
                using (SqlCommand command = new SqlCommand(insert, conn))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@loc", loc);
                    command.Parameters.AddWithValue("@date", date);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Event Created Successfully !", "Created Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
