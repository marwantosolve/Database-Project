using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareApp
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string? report = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";
            string? eventName = comboBox2.SelectedItem != null ? comboBox2.SelectedItem.ToString() : "";
            string connString = "Server= localhost; Database= EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                if (report == "Number of Customers")
                {
                    string select = @"
                    SELECT event.name, COUNT(ticket.custid) AS ""number of customers""
                    FROM EVENT
                    JOIN TICKET ON TICKET.EVENTID = EVENT.ID
                    WHERE TICKET.ISAVALIABLE = 0
                    AND EVENT.NAME = @eventName
                    GROUP BY EVENT.NAME;
                    ";
                    SqlCommand command = new SqlCommand(select, conn);
                    command.Parameters.AddWithValue("@eventName", eventName);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.ClearSelection();
        }

        Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            // Save the original size and scroll bar settings of the DataGridView
            int originalHeight = dataGridView1.Height;
            int originalWidth = dataGridView1.Width;
            ScrollBars originalScrollBars = dataGridView1.ScrollBars;

            // Temporarily disable scroll bars
            dataGridView1.ScrollBars = ScrollBars.None;

            // Calculate the total width needed to fit all columns
            int totalWidth = dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Visible)
                {
                    totalWidth += column.Width;
                }
            }

            // Calculate the total height needed to fit all rows, including the headers
            int totalHeight = dataGridView1.ColumnHeadersHeight + (dataGridView1.RowCount * dataGridView1.RowTemplate.Height);

            // Set the DataGridView size to fit all content
            dataGridView1.Width = totalWidth;
            dataGridView1.Height = totalHeight;

            // Create a bitmap with the adjusted size
            Bitmap bitmap = new Bitmap(totalWidth, totalHeight);

            // Draw the DataGridView onto the bitmap
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, totalWidth, totalHeight));

            // Restore the original size and scroll bar settings of the DataGridView
            dataGridView1.Width = originalWidth;
            dataGridView1.Height = originalHeight;
            dataGridView1.ScrollBars = originalScrollBars;

            // Display the bitmap in a PrintPreviewDialog
            printPreviewDialog1.Document = new PrintDocument();
            printPreviewDialog1.Document.PrintPage += (sender, e) =>
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            };
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string connString = "Server= localhost; Database= EventDB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string sqlQuerySelect = "SELECT [NAME] FROM EVENT;";
                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string eventName = reader.GetString("NAME");
                        comboBox2.Items.Add(eventName);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
