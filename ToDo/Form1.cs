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
            investments2.BringToFront();
        }

        private void gunaAdvenceButton9_Click(object sender, EventArgs e)
        {
            traveling1.BringToFront();
        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            misc1.BringToFront();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
           
        }


        private void gunaAdvenceButton10_Click(object sender, EventArgs e)
        {
            rewards1.Refresh();
            reading1.Refresh();
            learning1.Refresh();
            investments2.Refresh();
            projects1.Refresh();
            traveling1.Refresh();
            Application.Restart();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\canva\source\repos\ToDo\ToDo\todolist.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT listext FROM Rewards, Traveling, Learning, Reading, Investments, Projects, Misc"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        learning1.Text = sdr["learning"].ToString();
                    }
                    con.Close();
                }
            }

        }


    }
}
