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
    public partial class PayItem : UserControl
    {

        public  PayItem()
        {
            InitializeComponent();
        }


        public PayItem(string text)
        {
            InitializeComponent();
            label1.Text = text;
            //label2.Text;
            //base.OnMouseDown(tex);
        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
           Controls.Add(label1);

            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\canva\Documents\todolist.mdf;Integrated Security=True;Connect Timeout=30");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Payments WHERE listtext = '" + label1.Text + "' ", SQL);
                command.ExecuteNonQuery();
            }



            this.BackColor = Color.FromArgb(40, 177, 231);

            label2.Text = "DELETED";
        }

    }
}
