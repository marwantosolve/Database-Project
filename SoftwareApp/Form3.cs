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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 updateAcc = new Form5();
            updateAcc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 deleteAcc = new Form6();
            deleteAcc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 newEvent = new Form7();
            newEvent.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 setTicket = new Form9();
            setTicket.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 generateReport = new Form10();
            generateReport.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 addSponser = new Form8();
            addSponser.Show();
        }
    }
}
