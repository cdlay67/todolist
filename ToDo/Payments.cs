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
    public partial class Payments : UserControl
    {
        
        public Payments()
        {
            InitializeComponent();
            getToDolist();
        }

      

        int poss = 1;
        public void addItems(string text)
        {
            PayItem item = new ToDo.PayItem(text);
            flowLayoutPanel1.Controls.Add(item);
            item.Top = poss;
            poss = flowLayoutPanel1.Controls.Count * item.Height + 1;

            //ToDoItem[] todoItems = new ToDoItem[999];
            //listBox1.Items.Add(textbox.Text);

        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            string tarName = textbox.Text;
            addItems(tarName);
            addToDolist(tarName);
            // this.DragDrop(item);
            textbox.Text = "";
        }

        void getToDolist()
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\canva\Documents\todolist.mdf;Integrated Security=True;Connect Timeout=30");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Payments", SQL);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addItems("" + reader["listtext"]);
                    }
                }
            }
        }


        public void addToDolist(string insert)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\canva\Documents\todolist.mdf;Integrated Security=True;Connect Timeout=30");
            using (SQL)
            {
                SQL.Open();
                SqlCommand commandSec = new SqlCommand("INSERT INTO Payments (listtext) VALUES ('" + insert + "')", SQL);
                commandSec.ExecuteNonQuery();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //flowLayoutPanel2.Controls.Add(item);
        }
    }
}
