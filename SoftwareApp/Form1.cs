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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 signUp = new Form2();
            signUp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Server= localhost; Database= FCI; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string select = "SELECT * FROM [User] WHERE EMAIL = '@email' AND PASSWORD = '@pass' AND ROLE = '@role';";
                SqlCommand command = new SqlCommand(select, conn);
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
                } else
                {
                    MessageBox.Show("Please, Select your Role !");
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                }
                command.Parameters.AddWithValue("@rule", role);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                   if (role == "Admin" || role == "Organizer")
                   {
                        this.Hide();
                        Form3 adminForm = new Form3();
                        adminForm.Show();
                   } 
                   else
                   {
                        this.Hide();
                        Form4 adminForm = new Form4();
                        adminForm.Show();
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                MessageBox.Show("Invalid LOGIN Information !");
                textBox1.Clear();
                textBox3.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }
    }
}
