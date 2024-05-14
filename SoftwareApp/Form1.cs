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
            string connString = "Server=localhost; Database=EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
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
                    MessageBox.Show("Please, Select your Role !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    return;
                }
                string select = "SELECT * FROM [User] WHERE EMAIL = '"+textBox1.Text+"' AND PASSWORD = '"+textBox3.Text+"' AND ROLE = '"+role+"';";
                SqlDataAdapter da = new SqlDataAdapter(select,conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                   if (role == "Admin" || role == "Organizer")
                   {
                        Form3 adminForm = new Form3();
                        adminForm.Show();
                        this.Hide();
                   } 
                   else
                   {
                        Form4 CustForm = new Form4();
                        CustForm.Show();
                        this.Hide();
                   }
                }
                else
                {
                    MessageBox.Show("Invalid LOGIN Information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox3.Clear();
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
