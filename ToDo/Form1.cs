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

namespace ToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            learning1.BringToFront();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            projects1.BringToFront();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            rewards1.BringToFront();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            reading1.BringToFront();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            investments1.BringToFront();
        }

        private void gunaAdvenceButton9_Click(object sender, EventArgs e)
        {
            traveling1.BringToFront();
        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            payments1.BringToFront();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
