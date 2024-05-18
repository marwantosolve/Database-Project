using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;

namespace SoftwareApp
{
    public partial class Form14 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RIMAZ\MSSQLSERVER2; Database=Event; Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form14()
        {
            InitializeComponent();

            ViewTickets();
            
            


        }

        //Display the data on grind viewer
        void ViewTickets()
        {
            cmd = new SqlCommand("SELECT ticket.id, event.name, ticket.price, ticket.date FROM ticket, event WHERE ticket.eventid = event.id AND ticket.ISAVALIABLE = 1;", conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView.DataSource = dt;

            dr.Close();
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_purchase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_userid.Text))
            {
                MessageBox.Show("Please enter user ID");
            }
            else if(dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose a ticket.");
            }

            else if (dataGridView.SelectedRows.Count > 0 && !(string.IsNullOrEmpty(text_userid.Text)))
            {
                try
                {
                    var selectedRow = dataGridView.SelectedRows[0]; //gets the first row selected
                    int ticketId = Convert.ToInt32(selectedRow.Cells["id"].Value); 
                    int userid = Convert.ToInt32(text_userid.Text);

                    conn.Open();

                    string updateQuery = "UPDATE ticket SET ISAVALIABLE = 0, CUSTID = @userid WHERE id = @ticketId";
                    
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);
                    cmd.Parameters.AddWithValue("@userid", userid);

                    cmd.ExecuteNonQuery();
            

                    conn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                
            }
            

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
