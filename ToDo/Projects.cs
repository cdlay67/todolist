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
    public partial class Projects : UserControl
    {
        public Projects()
        {
            InitializeComponent();
            getToDolist();
            findToDolist();
        }



        int poss = 1;
        public void addItems(string text)
        {
            ToDoItem item = new ToDo.ToDoItem(text);
            flowLayoutPanel1.Controls.Add(item);
            item.Top = poss;
            poss = flowLayoutPanel1.Controls.Count * item.Height + 1;

            //ToDoItem[] todoItems = new ToDoItem[999];
            //listBox1.Items.Add(textbox.Text);

        }

        int pos = 1;
        public void saveItems(string text)
        {
            Completed item2 = new ToDo.Completed(text);
            flowLayoutPanel2.Controls.Add(item2);
            item2.Top = pos;
            pos = flowLayoutPanel2.Controls.Count * item2.Height + 1;

            //ToDoItem[] todoItems = new ToDoItem[999];
            //listBox1.Items.Add(textbox.Text);
        }



        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            string tarName = textbox.Text;
            addItems(tarName);
            addToDolist(tarName);
            saveItems(tarName);
            saveToDolist(tarName);
            textbox.Text = "";
        }

        void getToDolist()
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\canva\source\repos\ToDo\ToDo\todolist.mdf;Integrated Security=True;Connect Timeout=30");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Projects", SQL);
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
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\canva\source\repos\ToDo\ToDo\todolist.mdf;Integrated Security=True;Connect Timeout=30");
            using (SQL)
            {
                SQL.Open();
                SqlCommand commandSec = new SqlCommand("INSERT INTO Projects (listtext) VALUES ('" + insert + "')", SQL);
                commandSec.ExecuteNonQuery();
            }
        }

        void findToDolist()
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\canva\source\repos\ToDo\ToDo\todolist.mdf;Integrated Security=True;Connect Timeout=30");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command3 = new SqlCommand("SELECT * FROM Complete", SQL);
                using (SqlDataReader reader = command3.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        saveItems("" + reader["listtext"]);
                    }
                }
            }
        }

        public void saveToDolist(string insert)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\canva\source\repos\ToDo\ToDo\todolist.mdf;Integrated Security=True;Connect Timeout=30");
            using (SQL)
            {
                SQL.Open();
                SqlCommand commandSec = new SqlCommand("INSERT INTO Complete (Projecttext) VALUES ('" + insert + "')", SQL);
                commandSec.ExecuteNonQuery();
            }
        }
    }
}
