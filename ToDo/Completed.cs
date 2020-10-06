using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ToDo
{
    public partial class Completed : UserControl
    {

        public Completed()
        {
            InitializeComponent();
        }


        public Completed(string text)
        {
            InitializeComponent();
            label1.Text = text;
            //label2.Text = Payments label;
            

            //base.OnMouseDown(tex);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)

        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\canva\source\repos\ToDo\ToDo\todolist.mdf;Integrated Security=True;Connect Timeout=30");
            using (SQL)
            {
                SQL.Open();
                //SqlCommand command = new SqlCommand("INSERT INTO Investments (completed) VALUES ('" + label1.Text + "')", SQL);
                //SqlCommand command2 = new SqlCommand("DELETE FROM Learning WHERE listtext = '" + label1.Text + "' ", SQL);
                //SqlCommand command3 = new SqlCommand("DELETE FROM Projects WHERE listtext = '" + label1.Text + "' ", SQL);
                //SqlCommand command4 = new SqlCommand("DELETE FROM Rewards WHERE listtext = '" + label1.Text + "' ", SQL);
                //SqlCommand command5 = new SqlCommand("DELETE FROM Reading WHERE listtext = '" + label1.Text + "' ", SQL);
                //SqlCommand command6 = new SqlCommand("DELETE FROM Traveling WHERE listtext = '" + label1.Text + "' ", SQL);
                //command.ExecuteNonQuery();
                //command2.ExecuteNonQuery();
                //command3.ExecuteNonQuery();
                //command4.ExecuteNonQuery();
                //command5.ExecuteNonQuery();
                //command6.ExecuteNonQuery();
            }

            this.BackColor = Color.FromArgb(40, 177, 231);

            

            label2.Text = "COMPLETED";
        }
    }
}
