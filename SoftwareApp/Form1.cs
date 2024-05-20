using System.Data;
using System.Data.SqlClient;



namespace SoftwareApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 signUp = new Form2();
            signUp.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost; Database=EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked))
                {
                    MessageBox.Show("You must complete your information first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (radioButton1.Checked)
                {
                    //Admin
                    try
                    {
                        conn.Open();
                        string select = "SELECT * FROM [ADMIN] WHERE ID = " + textBox2.Text + " AND EMAIL = '" + textBox1.Text + "' AND PASSWORD = '" + textBox3.Text + "';";
                        SqlDataAdapter da = new SqlDataAdapter(select, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            SharedData.role = "Admin";
                            string id = textBox2.Text;
                            if (int.TryParse(id, out int custID))
                            {
                                SharedData.custID = custID;
                            }
                            Form3 adminForm = new Form3();
                            adminForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid LOGIN Information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radioButton2.Checked)
                {
                    // Organizer
                    try
                    {
                        conn.Open();
                        string select = "SELECT * FROM [ORGANIZER] WHERE ID = " + textBox2.Text + " AND EMAIL = '" + textBox1.Text + "' AND PASSWORD = '" + textBox3.Text + "';";
                        SqlDataAdapter da = new SqlDataAdapter(select, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            SharedData.role = "Organizer";
                            string id = textBox2.Text;
                            if (int.TryParse(id, out int custID))
                            {
                                SharedData.custID = custID;
                            }
                            Form3 adminForm = new Form3();
                            adminForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid LOGIN Information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radioButton3.Checked)
                {
                    // Customer
                    try
                    {
                        conn.Open();
                        string select = "SELECT * FROM [CUSTOMER] WHERE ID = " + textBox2.Text + " AND EMAIL = '" + textBox1.Text + "' AND PASSWORD = '" + textBox3.Text + "';";
                        SqlDataAdapter da = new SqlDataAdapter(select, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            SharedData.role = "Customer";
                            string id = textBox2.Text;
                            if (int.TryParse(id, out int custID))
                            {
                                SharedData.custID = custID;
                            }
                            Form4 custForm = new Form4();
                            custForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid LOGIN Information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
