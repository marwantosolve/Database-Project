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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string role = SharedData.role;
            int currentID = SharedData.custID;
            string connString = "Server=localhost; Database=EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            if (role == "Admin")
            {
                try
                {
                    conn.Open();
                    string select = "SELECT * FROM [ADMIN] WHERE ID = " + currentID + " AND PASSWORD = '" + textBox3.Text + "';";
                    SqlDataAdapter da = new SqlDataAdapter(select, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to Delete your Account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string delete = "DELETE FROM [ADMIN] WHERE ID = @currentID";
                            SqlCommand command = new SqlCommand(delete, conn);
                            command.Parameters.AddWithValue("@currentID", currentID);
                            command.ExecuteNonQuery();
                            MessageBox.Show("You've Deleted your Account Successfully !", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            Form1 login = new Form1();
                            login.Show();
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
                    else
                    {
                        MessageBox.Show("Invalid Confirmation !\nCheck your Information and try again ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (role == "Organizer")
            {
                try
                {
                    conn.Open();
                    string select = "SELECT * FROM [ORGANIZER] WHERE ID = " + currentID + " AND PASSWORD = '" + textBox3.Text + "';";
                    SqlDataAdapter da = new SqlDataAdapter(select, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to Delete your Account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string delete = "DELETE FROM [ORGANIZER] WHERE ID = @currentID";
                            SqlCommand command = new SqlCommand(delete, conn);
                            command.Parameters.AddWithValue("@currentID", currentID);
                            command.ExecuteNonQuery();
                            MessageBox.Show("You've Deleted your Account Successfully !", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            Form1 login = new Form1();
                            login.Show();
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
                    else
                    {
                        MessageBox.Show("Invalid Confirmation !\nCheck your Information and try again ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (role == "Customer")
            {
                try
                {
                    conn.Open();
                    string select = "SELECT * FROM [CUSTOMER] WHERE ID = " + currentID + " AND PASSWORD = '" + textBox3.Text + "';";
                    SqlDataAdapter da = new SqlDataAdapter(select, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to Delete your Account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string delete = "DELETE FROM [CUSTOMER] WHERE ID = @currentID";
                            SqlCommand command = new SqlCommand(delete, conn);
                            command.Parameters.AddWithValue("@currentID", currentID);
                            command.ExecuteNonQuery();
                            MessageBox.Show("You've Deleted your Account Successfully !", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            Form1 login = new Form1();
                            login.Show();
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
                    else
                    {
                        MessageBox.Show("Invalid Confirmation !\nCheck your Information and try again ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            if (SharedData.role == "Admin" || SharedData.role == "Organizer")
            {
                Form3 coordForm = new Form3();
                coordForm.Show();
            } else if (SharedData.role == "Customer")
            {
                Form4 custForm = new Form4();
                custForm.Show();
            } else
            {
                Form1 index = new Form1();
                index.Show();
            }
        }
    }
}
