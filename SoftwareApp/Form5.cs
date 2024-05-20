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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currentID = SharedData.custID;
            string role = SharedData.role;
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

                        if (!(textBox1.Text == ""))
                        {
                            string update = "UPDATE [ADMIN] SET ID = " + textBox1.Text + " WHERE ID = " + currentID + " ;";
                            SqlCommand command = new SqlCommand(update, conn);
                            command.ExecuteNonQuery();
                            string newID = textBox1.Text;
                            if (int.TryParse(newID, out int newINTID))
                            {
                                currentID = newINTID;
                            }
                        }
                        if (!(textBox2.Text == ""))
                        {
                            string update = "UPDATE [ADMIN] SET FULLNAME = '" + textBox2.Text + "' WHERE ID = " + currentID + " ;";
                            SqlCommand command = new SqlCommand(update, conn);
                            command.ExecuteNonQuery();
                        }
                        if (!(textBox6.Text == ""))
                        {
                            string update = "UPDATE [ADMIN] SET EMAIL = '" + textBox6.Text + "' WHERE ID = " + currentID + " ;";
                            SqlCommand command = new SqlCommand(update, conn);
                            command.ExecuteNonQuery();
                        }
                        if (!(textBox5.Text == ""))
                        {
                            string update = "UPDATE [ADMIN] SET PASSWORD = '" + textBox5.Text + "' WHERE ID = " + currentID + " ;";
                            SqlCommand command = new SqlCommand(update, conn);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("You've Updated your Account Info Successfully !", "Informations Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
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
                        if (!(textBox1.Text == ""))
                        {
                            string update = "UPDATE [ORGANIZER] SET ID = " + textBox1.Text + " WHERE ID = " + currentID + " ;";
                            SqlCommand command = new SqlCommand(update, conn);
                            command.ExecuteNonQuery();
                            string newID = textBox1.Text;
                            if (int.TryParse(newID, out int newINTID))
                            {
                                currentID = newINTID;
                            }
                        }
                        if (!(textBox2.Text == ""))
                        {
                            string update = "UPDATE [ORGANIZER] SET FULLNAME = '" + textBox2.Text + "' WHERE ID = " + currentID + " ;";
                            SqlCommand command = new SqlCommand(update, conn);
                            command.ExecuteNonQuery();
                        }
                        if (!(textBox6.Text == ""))
                        {
                            string update = "UPDATE [ORGANIZER] SET EMAIL = '" + textBox6.Text + "' WHERE ID = " + currentID + " ;";
                            SqlCommand command = new SqlCommand(update, conn);
                            command.ExecuteNonQuery();
                        }
                        if (!(textBox5.Text == ""))
                        {
                            string update = "UPDATE [ORGANIZER] SET PASSWORD = '" + textBox5.Text + "' WHERE ID = " + currentID + " ;";
                            SqlCommand command = new SqlCommand(update, conn);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("You've Updated your Account Info Successfully !", "Informations Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
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
                        if (!(textBox1.Text == ""))
                        {
                            string update = "UPDATE [CUSTOMER] SET ID = " + textBox1.Text + " WHERE ID = " + currentID + " ;";
                            SqlCommand command = new SqlCommand(update, conn);
                            command.ExecuteNonQuery();
                            string newID = textBox1.Text;
                            if (int.TryParse(newID, out int newINTID))
                            {
                                currentID = newINTID;
                            }
                        }
                        if (!(textBox2.Text == ""))
                        {
                            string update = "UPDATE [CUSTOMER] SET FULLNAME = '" + textBox2.Text + "' WHERE ID = " + currentID + " ;";
                            SqlCommand command = new SqlCommand(update, conn);
                            command.ExecuteNonQuery();
                        }
                        if (!(textBox6.Text == ""))
                        {
                            string update = "UPDATE [CUSTOMER] SET EMAIL = '" + textBox6.Text + "' WHERE ID = " + currentID + " ;";
                            SqlCommand command = new SqlCommand(update, conn);
                            command.ExecuteNonQuery();
                        }
                        if (!(textBox5.Text == ""))
                        {
                            string update = "UPDATE [CUSTOMER] SET PASSWORD = '" + textBox5.Text + "' WHERE ID = " + currentID + " ;";
                            SqlCommand command = new SqlCommand(update, conn);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("You've Updated your Account Info Successfully !", "Informations Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.PasswordChar = checkBox2.Checked ? '\0' : '*';
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
