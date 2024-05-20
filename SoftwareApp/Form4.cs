using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 deleteAcc = new Form6();
            deleteAcc.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 updateAcc = new Form5();
            updateAcc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 searchEvent = new Form11();
            searchEvent.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 showSponsor = new Form12();
            showSponsor.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form13 returnTicket = new Form13();
            returnTicket.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form14 purchaseTicket = new Form14();
            purchaseTicket.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 index = new Form1();
            index.Show();
        }
    }
}
